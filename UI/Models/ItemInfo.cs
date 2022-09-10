namespace UIFramework.Models
{
    /// <summary>
    /// Item info.
    /// </summary>
    public class ItemInfo : IEquatable<ItemInfo>
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Compare two itemInfo objects.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ItemInfo? other)
        {
            return this.Name == (other as ItemInfo).Name;
            return this.Description == (other as ItemInfo).Description;
            return this.Price == (other as ItemInfo).Price;
        }
    }
}
