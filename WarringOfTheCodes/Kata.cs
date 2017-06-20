using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WarringOfTheCodes
{
    //http://www.codewars.com/kata/paginationhelper

    public class PagnationHelper<T>
    {
        // TODO: Complete this class

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        public IList<T> collection { get; set; }
        public int itemsPerPage { get; set; }

        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;

        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return this.collection.Count();
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return (this.collection.Count() / this.itemsPerPage) + 1;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex )
        {
            
            if (pageIndex > -1 && pageIndex < this.PageCount-1)
            {
                return this.itemsPerPage;
            }
            else if (pageIndex == this.PageCount-1)
            {
                return this.ItemCount - (pageIndex * this.itemsPerPage);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            
            if (itemIndex < this.ItemCount && itemIndex > -1)
            {
                return itemIndex / this.itemsPerPage;
            }
            else
            {
                return -1;
            }
        }
    }
}
