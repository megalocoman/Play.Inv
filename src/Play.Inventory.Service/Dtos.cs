using System;

namespace Play.Inventory.Service.dtos
{
    public record CatalogItemDto(Guid Id, string Name, string Description);

    public record GrantItemsDto(Guid UserId, Guid CatalodItemId, int Quantity);

    public record InventoryItemDto(Guid CatalodItemId, string name, string Description, int Quantity, 
                                    DateTimeOffset AcquiredDate);

                                    

}