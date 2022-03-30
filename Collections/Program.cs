using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entityList = new List<Entity>()
            {   new Entity { Id = 1, ParentId = 0, Name = "Root entity"},

                new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity"},

                new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity"},

                new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity"},

                new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity"}
            };

            var result = FindPeoplesParents(entityList);
        }

        public static Dictionary<int, List<Entity>> FindPeoplesParents (List<Entity> entityes)
        {
            var res = new Dictionary<int, List<Entity>>();

            foreach (var entity in entityes)
            {
                res.TryAdd(entity.ParentId, new List<Entity>());
                res[entity.ParentId].Add(entity);
            }
            return res;
        }
    }
}
