using CmdLine.Domain;
using FluentNHibernate.Mapping;

namespace CmdLine.DataAccess.Maps
{
   public class TodoListMap : ClassMap<TodoList>
   {
      public TodoListMap()
      {
         Id(x => x.Id);
         Map(x => x.Name);
         HasMany(x => x.Items).Cascade.SaveUpdate().Not.LazyLoad();
      }
   }
}
