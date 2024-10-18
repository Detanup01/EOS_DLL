using EOS_SDK._log;
using EOS_SDK._test;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EOS_SDK._Data
{
    public class NotifyManager
    {
        public static Dictionary<string, MethodInfo> StructNameToSetMethod = [];

        static NotifyManager()
        {
            Logger.WriteDebug("NotifyManager!!");
            StructNameToSetMethod.Add(nameof(test_exports.AddNotifyResult), GetMethodInfo(test_exports.AddNotifyResult.Set));
            StructNameToSetMethod.Add(nameof(test_exports.TriggerNotifyResult), GetMethodInfo(test_exports.TriggerNotifyResult.Set));
            StructNameToSetMethod.Add(nameof(Achievements.OnAchievementsUnlockedCallbackInfo), GetMethodInfo(Achievements.OnAchievementsUnlockedCallbackInfo.Set));
            StructNameToSetMethod.Add(nameof(Achievements.OnAchievementsUnlockedCallbackV2Info), GetMethodInfo(Achievements.OnAchievementsUnlockedCallbackV2Info.Set));
            // Add more structs here
            /*
            foreach (var item in StructNameToSetMethod)
            {
                Logger.WriteDebug(item.Key + " " + item.Value.Name + " ");
                foreach (var item1 in item.Value.GetParameters())
                {
                    Logger.WriteDebug(item1.Name + " " + item1.ParameterType.FullName);

                }
            }*/
        }

        static MethodInfo GetMethodInfo(Delegate d)
        {
            return d.Method;
        }

        public struct Notify
        {
            public ulong Id;
            public object struct_obj;
            public Type struct_type;
            public bool IsTriggered;
            public string nameTrigger;
            public IntPtr delegator;
            public int type_size;

            public override string ToString()
            {
                return $"[Notify] Id: {Id}, StructObj: {struct_obj}, StructType: {struct_type.Name}, IsTriggered: {IsTriggered}, NameTrigger: {nameTrigger}, delegatorPtr: {delegator}, Size: {type_size}";
            }
        }

        static ulong NotifyNext = 1;

        public static void PrintConvertStructs<A,B>([DisallowNull] A struct_a, [DisallowNull] B struct_b)
        {
            Logger.WriteDebug(struct_a.ToString()!);
            Logger.WriteDebug("StructA Type Name: " + struct_a.GetType().Name + "\n");
            Logger.WriteDebug("Getting Struct Set method");
            if (!StructNameToSetMethod.TryGetValue(struct_a.GetType().Name, out var methodInfo))
            {
                Logger.WriteDebug("No Struct name cached!");
            }
            if (methodInfo != null && methodInfo.GetParameters()[1].ParameterType == struct_b.GetType())
            {
                Logger.WriteDebug("Method is null or the [1] param is not our desired type !");
            }
            var method1_ = methodInfo;
            Logger.WriteDebug("IsMethodNull: " + (method1_ == null));
            if (method1_ != null)
            {
                Logger.WriteDebug("Method Name (Should be Set): " + method1_.Name);
                foreach (var item in method1_.GetParameters())
                {
                    Logger.WriteDebug("Parameter (Type, Name): " + item.ParameterType.Name + " | " + item.Name);
                }
                Logger.WriteDebug("Set Should be invoked NOW!");
                var will_be_struct_b = method1_.Invoke(struct_a, [struct_a, struct_b]);
                Logger.WriteDebug("Returned Struct is null? "+(will_be_struct_b == null));
                Logger.WriteDebug("Returned struct Type Name: " + will_be_struct_b?.GetType().Name);
                Logger.WriteDebug(will_be_struct_b?.ToString()!);

            }
        }

        public static IntPtr ConvertStruct<B>([DisallowNull] Notify notify, [DisallowNull] B struct_helper)
        {
            if (!StructNameToSetMethod.TryGetValue(notify.struct_type.Name, out var methodInfo))
            {
               return IntPtr.Zero;
            }

            if (methodInfo != null && methodInfo.GetParameters()[1].ParameterType == struct_helper.GetType())
            {
                var will_be_struct_b = methodInfo.Invoke(notify.struct_obj, [notify.struct_obj, struct_helper]);
                if (will_be_struct_b == null)
                    return IntPtr.Zero;
                return Helpers.StructToPtr(will_be_struct_b, notify.type_size);
            }
            return IntPtr.Zero;
        }


        static Dictionary<ulong, Notify> Notifies = new();

        public static ulong AddNotify<T>(string nametotrigger, IntPtr delegator, [DisallowNull] T struct_to_send)
        {
            var id = NotifyNext++;
            Notify notify = new()
            {
                Id = id,
                delegator = delegator,
                IsTriggered = false,
                nameTrigger = nametotrigger,
                struct_obj = struct_to_send,
                struct_type = typeof(T),
                type_size = Marshal.SizeOf<T>()
            };

            Logger.WriteDebug($"[NotifyManager] Added Notify: {notify.ToString()}");
            Notifies.Add(id, notify);
            return id;
        }
        public static void RemoveNotify(ulong id)
        {
            Logger.WriteDebug($"[NotifyManager] Removed Notify with ID: {id}");
            Notifies.Remove(id);
        }
        public static unsafe void TriggerNotify<T>(string name, [DisallowNull] T struct_from_notfiy)
        {
            var notifyDict = Notifies.Where(n => n.Value.nameTrigger == name).ToDictionary();
            if (notifyDict == null)
                return;
            if (notifyDict.Count > 1)
            {
                Logger.WriteWarn("[NotifyManager] Triggered Notifies are more than 1! Structure dumps are sent to Verbose/Debug");
                foreach (var item in notifyDict.Values)
                {
                    Logger.WriteDebug(item.ToString());
                }
                return;
            }

            var notify = notifyDict.FirstOrDefault().Value;
            if (notify.Id == 0)
                return;
            
            PrintConvertStructs(notify.struct_obj, struct_from_notfiy); //printer struct (make to print debugVV)
            var ptr = ConvertStruct(notify, struct_from_notfiy);
            if (ptr == IntPtr.Zero)
                return;
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notify.delegator;
            @delegate(ptr);
            notify.IsTriggered = true;
            Logger.WriteDebug("[NotifyManager] Notify Triggered: " + notify.ToString());   //Initial Data
        }
    }
}
