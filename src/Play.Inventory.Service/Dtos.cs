using System;

namespace Play.Inventory.Service.dtos
{
    public record GrantItemsDto(Guid UserId, Guid CatalodItemId, int Quantity);

    public record InventoryItemDto(Guid CatalodItemId, int Quantity, DateTimeOffset AcquiredDate);

}