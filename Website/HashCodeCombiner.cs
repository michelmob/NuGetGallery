﻿// Copied from https://aspnetwebstack.codeplex.com/SourceControl/changeset/view/75b5e7ea58d2a120242ff0d840600e33e9b65882#src/HashCodeCombiner.cs
// Used under the Apache 2 License.

// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections;

namespace Microsoft.Internal.Web.Utils
{
    internal class HashCodeCombiner
    {
        private long _combinedHash64 = 0x1505L;

        public int CombinedHash
        {
            get { return _combinedHash64.GetHashCode(); }
        }

        public HashCodeCombiner Add(IEnumerable e)
        {
            if (e == null)
            {
                Add(0);
            }
            else
            {
                int count = 0;
                foreach (object o in e)
                {
                    Add(o);
                    count++;
                }
                Add(count);
            }
            return this;
        }

        public HashCodeCombiner Add(int i)
        {
            _combinedHash64 = ((_combinedHash64 << 5) + _combinedHash64) ^ i;
            return this;
        }

        public HashCodeCombiner Add(object o)
        {
            int hashCode = (o != null) ? o.GetHashCode() : 0;
            Add(hashCode);
            return this;
        }

        public static HashCodeCombiner Start()
        {
            return new HashCodeCombiner();
        }
    }
}