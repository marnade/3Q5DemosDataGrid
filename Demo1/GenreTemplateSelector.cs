using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Demo1
{
    public class GenreTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HommeTemplate { get; set; }
        public DataTemplate FemmeTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item,
                      DependencyObject container)
        {
            var informaticien = item as Informaticien;
            if (informaticien == null)
                return base.SelectTemplate(item, container);

            if (informaticien.Genre == Informaticien.GenreEnum.Homme)
                return HommeTemplate;
            return FemmeTemplate;
        }
    }
}
