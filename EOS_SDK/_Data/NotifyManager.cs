using EOS_SDK._log;
using System.Diagnostics.CodeAnalysis;

namespace EOS_SDK._Data
{
    public class NotifyManager
    {
        internal struct Notify
        {
            public ulong Id;
            public object struct_obj;
            public Type struct_type;
            public bool IsTriggered;
            public string nameTrigger;
            public IntPtr delegator;

            public override string ToString()
            {
                return $"[Notify] Id: {Id}, StructObj: {struct_obj}, StructType: {struct_type.Name}, IsTriggered: {IsTriggered}, NameTrigger: {nameTrigger}, delegatorPtr: {delegator}";
            }
        }

        static ulong NotifyNext = 1;

        public static void PrintConvertStructs<T,B>([DisallowNull] T struct_a, [DisallowNull] B struct_b)
        {
            Logger.WriteDebug(struct_a.ToString()!);
            Logger.WriteDebug("StructA Type Name: " + struct_a.GetType().Name + "\n");
            Logger.WriteDebug("Getting Struct Set method:");

            var method1_ = struct_a.GetType().GetMethods().Where(x => x.Name == "Set" && x.GetParameters().Where(param => param.ParameterType == struct_b.GetType()).Any()).FirstOrDefault();
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
                Logger.WriteDebug("Returned Struct is null?: "+(will_be_struct_b == null));
                Logger.WriteDebug("Returned struct Type Name" + will_be_struct_b?.GetType().Name);
                Logger.WriteDebug(will_be_struct_b?.ToString()!);

            }
        }

        public static IntPtr ConvertStruct<T, B>([DisallowNull] T struct_base, [DisallowNull] B struct_helper)
        {
            var method = struct_base.GetType().GetMethods().Where(x=>x.Name == "Set" && x.GetParameters().Where(param=>param.ParameterType == struct_helper.GetType()).Any()).FirstOrDefault();
            if (method != null)
            {
                var will_be_struct_b = method.Invoke(struct_base, [struct_base, struct_helper]);
                if (will_be_struct_b == null)
                    return IntPtr.Zero;
                return Helpers.StructToPtr(will_be_struct_b, will_be_struct_b.GetType());
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
                struct_type = typeof(T)
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
            var ptr = ConvertStruct(notify.struct_obj, struct_from_notfiy);
            if (ptr == IntPtr.Zero)
                return;
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notify.delegator;
            @delegate(ptr);
            notify.IsTriggered = true;
            Logger.WriteDebug("[NotifyManager] Notify Triggered: " + notify.ToString());   //Initial Data
        }
    }
}
