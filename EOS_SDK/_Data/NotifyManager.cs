using EOS_SDK._log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EOS_SDK._Data.NotifyManager;

namespace EOS_SDK._Data
{
    internal class NotifyManager
    {
        internal struct Notify
        {
            public int Id;
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

        static int NotifyNext = 1;

        public static void ConvertStructs<T,B>(T struct_a, B struct_b)
        {
            Console.WriteLine(struct_a.ToString());
            Console.WriteLine(struct_a.GetType().Name);
            Console.WriteLine("getting A Set method:");
            var method = struct_a.GetType().GetMethod("Set");
            Console.WriteLine(method == null);
            if (method != null)
            {
                var will_be_struct_b = method.Invoke(struct_a, [struct_a]);
                Console.WriteLine(will_be_struct_b.ToString());
                Console.WriteLine(will_be_struct_b.GetType().Name);
            }
            Console.WriteLine("-*-");
            Console.WriteLine(struct_b.ToString());
            Console.WriteLine(struct_b.GetType().Name);
            Console.WriteLine("getting A Set method:");
            method = struct_b.GetType().GetMethod("Set");
            Console.WriteLine(method == null);
            if (method != null)
            {
                var will_be_struct_a = method.Invoke(struct_b, [struct_b]);
                Console.WriteLine(will_be_struct_a.ToString());
                Console.WriteLine(will_be_struct_a.GetType().Name);
            }
        }

        static Dictionary<int, Notify> Notifies = new();

        public static int AddNotify<T>(string nametotrigger, IntPtr delegator, T struct_to_send)
        {
            var id = NotifyNext++;
            Notify notify = new()
            { 
                Id = id,
                delegator = delegator,
                IsTriggered = false,
                nameTrigger = nametotrigger,
                struct_obj = (object)struct_to_send,
                struct_type = typeof(T)
            };

            Notifies.Add(id, notify);
            return id;
        }
        public static void RemoveNotify(int id)
        {
            Notifies.Remove(id);
        }
        public static void TriggerNotify<T>(string name, T struct_from_notfiy)
        {
            Notify notify = new()
            {
                Id = 0
            };
            foreach (var item in Notifies.Values)
            {
                if (item.nameTrigger == name)
                    notify = item;
            }
            if (notify.Id == 0)
                return;
            ConvertStructs(notify.struct_obj, struct_from_notfiy);
        }

        public static void TriggerNotify<T>(int id, T struct_from_notfiy)
        {
            var notify = Notifies[id];
            
            ConvertStructs(notify.struct_obj, struct_from_notfiy);
        }

        public static unsafe void Update() //Or Tick
        {
            foreach (var item in Notifies)
            {

            }
        }
    }
}
