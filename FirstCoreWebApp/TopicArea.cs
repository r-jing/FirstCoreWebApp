using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWebApp
{
    public class TopicArea
    {
        public string Name { get; set; }
    }

    public interface ITopicAreaService
    {
        IEnumerable<TopicArea> GetAllTopicAreas();
    }

    public class TopicAreaService : ITopicAreaService
    {
        public IEnumerable<TopicArea> GetAllTopicAreas()
        {
            return new List<TopicArea>
            {
                new TopicArea {Name =".NET Core" },
                new TopicArea {Name ="Docker" },
                new TopicArea { Name ="C#" }
            };
        }
    }
}
