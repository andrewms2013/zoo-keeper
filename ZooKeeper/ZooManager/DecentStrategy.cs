﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.Animals;

namespace ZooKeeper.ZooManager
{
    class DecentStrategy: IShopStrategy
    {
        public bool IsStoreAccessible(AnimalsStore store)
        {
            if(store is MiddleLevelStore)
            {
                return false;
            }
            if(store is PremiumStore)
            {
                return false;
            }
            return true;
        }
    }
}
