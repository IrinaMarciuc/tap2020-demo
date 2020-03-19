﻿using System;

namespace Tap2020Demo
{
    abstract class Account : AccountBase
    {
        public decimal Withdraw(decimal amount)
        {
            return WithdrawInternal(amount);
        }

        protected virtual decimal WithdrawInternal(decimal amount)
        {
            if (Amount < amount)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }

            Amount -= amount;
            return amount;
        }
    }
}
