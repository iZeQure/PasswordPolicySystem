﻿namespace WebLoginDemo.Data.Validators.Abstractions
{
    public interface IPolicyRule
    {
        void ValidatePolicy(object value, ref Validator validator);
    }
}
