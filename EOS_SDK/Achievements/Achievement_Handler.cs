using EOS_SDK._Data;
using EOS_SDK._Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Achievements
{
    internal class Achievement_Handler
    {
        public struct Handler
        {
            public List<Achievement_Model> Achievements;

        }

        public static IntPtr Create()
        {
            //  Load achivements
            // struct to PTR | or just send random ptr?

            return IntPtr.CreateChecked(SDK.AchivementPTR);

        }

    }
}
