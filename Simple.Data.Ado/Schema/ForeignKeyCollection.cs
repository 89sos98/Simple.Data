﻿using System.Collections.ObjectModel;

namespace Simple.Data.Ado.Schema
{
    class ForeignKeyCollection : KeyedCollection<TableName, ForeignKey>
    {
        /// <summary>
        /// When implemented in a derived class, extracts the key from the specified element.
        /// </summary>
        /// <returns>
        /// The key for the specified element.
        /// </returns>
        /// <param name="item">The element from which to extract the key.</param>
        protected override TableName GetKeyForItem(ForeignKey item)
        {
            return item.MasterTable;
        }
    }
}
