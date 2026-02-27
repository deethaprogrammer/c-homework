public class ShoppingCart
{
    public List<GroupedShopItem> Groceries = [];

    public void AddItem(ShopItem item)
    {
        GroupedShopItem shopitem = FindItem(item);
        if (shopitem != null)
        {
            shopitem.Quantity++;
        }
        else
        {
            Groceries.Add(new GroupedShopItem(item));
        }
    }
    public GroupedShopItem? FindItem(ShopItem item)
    {
        foreach (GroupedShopItem shopitem in Groceries)
        {
            if (shopitem.Item.ID == item.ID)
            {
                return shopitem;
            }
        }
        return null;
    }
    public string GetContentsOverview()
    {
        string items = "";
        foreach (GroupedShopItem shopitem in Groceries)
        {
            items += $"{shopitem.Item.Name} x {shopitem.Quantity}";
        }
        return items;
    }
    public double GetTotalPrice()
    {
        double total = 0.0;
        foreach (GroupedShopItem shopitem in Groceries)
        {
            total += shopitem.Item.Price * shopitem.Quantity;
        }
        return total;
    }
}