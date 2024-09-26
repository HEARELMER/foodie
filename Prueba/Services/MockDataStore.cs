using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
{
    new Item { Id = Guid.NewGuid().ToString(), Text = "Ceviche", Description="Plato de pescado crudo marinado en jugo de limón." },
    new Item { Id = Guid.NewGuid().ToString(), Text = "Lomo Saltado", Description="Plato de carne salteada con cebolla, tomate y papas fritas." },
    new Item { Id = Guid.NewGuid().ToString(), Text = "Ají de Gallina", Description="Plato de pollo desmenuzado en una salsa de ají amarillo." },
    new Item { Id = Guid.NewGuid().ToString(), Text = "Anticuchos", Description="Brochetas de corazón de res marinadas y asadas." },
    new Item { Id = Guid.NewGuid().ToString(), Text = "Papa a la Huancaína", Description="Papas hervidas con salsa de ají amarillo y queso." },
    new Item { Id = Guid.NewGuid().ToString(), Text = "Tacu Tacu", Description="Plato de arroz y frijoles refritos, a menudo servido con carne." }
};
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}