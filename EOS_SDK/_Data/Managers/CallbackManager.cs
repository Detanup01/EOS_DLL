using EOS_SDK._Coroutines;
using EOS_SDK._log;
using System.Diagnostics.CodeAnalysis;

namespace EOS_SDK._Data
{
    public class CallbackManager
    {
        static Dictionary<IntPtr /* CallbackDelege */, (IntPtr stuct_ptr, string name) /* CallbackStruct */> Callbacks = new();
        static Dictionary<IntPtr /* CallbackDelege */, (IntPtr stuct_ptr, string name) /* CallbackStruct */> TMP_Callbacks = new();
        public static void AddCallback<T>(IntPtr ptr, [DisallowNull] T callbackStruct, string name)
        {
            Callbacks.Add(ptr, (Helpers.StructToPtr(callbackStruct), nameof(callbackStruct)));
            Logger.Write($"Callback Added {name} | {nameof(callbackStruct)}");
        }

        public static unsafe void Update() //Or Tick
        {
            foreach (var item in Callbacks)
            {
                delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)item.Key;
                @delegate(item.Value.stuct_ptr);
                Logger.Write($"Callback Called {item.Value.name}");
                Callbacks.Remove(item.Key);
                Logger.Write($"Callback removed {item.Value.name}");
            }
        }

        public static void WaitDelegateForCompletion(IntPtr ptr, Func<bool> action)
        {
            TMP_Callbacks.Add(ptr, Callbacks[ptr]);
            Callbacks.Remove(ptr);
            CoroutineWorker.StartCoroutine(_WaitForTrue(action, ptr));
        }

        static IEnumerator<double> _WaitForTrue(Func<bool> action, IntPtr ptr)
        {
            yield return CoroutineWorker.WaitUntilTrue(action);
            Callbacks.Add(ptr, TMP_Callbacks[ptr]);
            TMP_Callbacks.Remove(ptr);
            yield return 0f;
        }
        public static void CleanCallbacks()
        {
            Callbacks.Clear();
        }       
    }
}
