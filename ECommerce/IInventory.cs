namespace ECommerce
{
    public interface IInventory
    {
        bool IsItemAvailable(Product product, uint quantity);
    }
}