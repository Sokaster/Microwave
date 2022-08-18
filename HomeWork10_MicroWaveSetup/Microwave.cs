using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10_MicroWaveSetup
{
    public delegate void NotifyWarmUpCompleted(string nameOfFood);
    internal class Microwave
    {

        public event NotifyWarmUpCompleted WarmUpCompleted;

        public void WarmUp(string nameOfFood)
        {
            Console.WriteLine($"Подогреваю {nameOfFood}");
            WarmUpCreated(nameOfFood);
        }

        protected virtual void WarmUpCreated(string nameOfFood)
        {
            if (WarmUpCompleted != null)
            {
                WarmUpCompleted.Invoke(nameOfFood);
            }
        }


    }
}
