using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Infrostruktura_TK_test_task.Models
{
    public class Variable
    {
        public struct GroupsList
        {
            public string group_name;//название группы
            public List<Variable> list_variables;//список переменных в группе
        }
        public string Name { get; set; }
        public string Description { get; set; }

        //public static List<GroupsList> GetVariables()//TOOD: Заглушка
        //{

        //    var Plants = new List<Variable>()
        //    {
        //        new Variable{Name = "Ромашка",Description = "Ромашка - благородный цветок" },
        //        new Variable{Name = "Фикус",Description = "Фикус - домашний цветок" },
        //        new Variable{Name = "Кактус",Description = "Кактус - цветок, требующий малого кол-ва воды" }
        //    };

        //    var Cars = new List<Variable>()
        //    {
        //        new Variable{Name = "Porshe 911",Description = "Porshe 911 зеленого цвета с открытой крышей" },
        //        new Variable{Name = "BMW x5",Description = "BMW x5 черного цвета" },
        //        new Variable{Name = "Ferrari",Description = "Ferrari желтого цвета" }
        //    };

        //    var Houses = new List<Variable>()
        //    {
        //        new Variable{Name = "Коттедж",Description = "Топовое место для вечеринок" },
        //        new Variable{Name = "Загородный дом",Description = "Неплохой дом с огородом" },
        //        new Variable{Name = "Трущобы",Description = "Ужасное место чтобы жить" }
        //    };

        //    var groups_list = new List<GroupsList>()
        //    {
        //        new GroupsList { group_name ="Plants",list_variables = Plants},
        //        new GroupsList { group_name ="Cars",list_variables = Cars},
        //        new GroupsList { group_name ="Houses",list_variables = Houses}
        //    };

        //    return groups_list;

        //}
        
        public static List<Variable_with_group> GetVariables()
        {
            var Plants = new List<Variable>()
                {
                    new Variable{Name = "Ромашка",Description = "Ромашка - благородный цветок" },
                    new Variable{Name = "Фикус",Description = "Фикус - домашний цветок" },
                    new Variable{Name = "Кактус",Description = "Кактус - цветок, требующий малого кол-ва воды" }
                };

            var Cars = new List<Variable>()
                {
                    new Variable{Name = "Porshe 911",Description = "Porshe 911 зеленого цвета с открытой крышей" },
                    new Variable{Name = "BMW x5",Description = "BMW x5 черного цвета" },
                    new Variable{Name = "Ferrari",Description = "Ferrari желтого цвета" }
                };

            var Houses = new List<Variable>()
                {
                    new Variable{Name = "Коттедж",Description = "Топовое место для вечеринок" },
                    new Variable{Name = "Загородный дом",Description = "Неплохой дом с огородом" },
                    new Variable{Name = "Трущобы",Description = "Ужасное место чтобы жить" }
                };

            var groups_list = new List<GroupsList>()
                {
                    new GroupsList { group_name ="Plants",list_variables = Plants},
                    new GroupsList { group_name ="Cars",list_variables = Cars},
                    new GroupsList { group_name ="Houses",list_variables = Houses}
                };



            var vars_with_group = new List<Variable_with_group>(100 * 1000); //TODO:Список всех переменных с именами их групп  100 групп по 1000 переменных
           
            foreach (var group in groups_list)//TODO избавиться бы от вложенности циклов
            {
                foreach (var variable in group.list_variables)
                {
                    vars_with_group.Add(new Variable_with_group 
                    { Group = group.group_name, 
                      Name = variable.Name,
                      Description = variable.Description 
                    });
                }                
            }
            return vars_with_group;
        }
    }
}
