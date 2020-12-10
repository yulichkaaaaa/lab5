using System;

namespace DIContainer
{
    public class ImplementationInfo
    {
        public readonly Type implClassType;
        public readonly bool isSingleton;

        public ImplementationInfo(bool _isSingleton, Type impl)
        {
            implClassType = impl;
            isSingleton = _isSingleton;
        }

    }
}
