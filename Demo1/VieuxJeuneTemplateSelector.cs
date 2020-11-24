using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Demo1
{
    public class VieuxJeuneTemplateSelector : DataTemplateSelector
    {
        public DataTemplate VieuxTemplate { get; set; }
        public DataTemplate JeuneTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item,
                      DependencyObject container)
        {
            var informaticien = item as Informaticien;
            if (informaticien == null)
                return base.SelectTemplate(item, container);

            if (informaticien.DDN > new DateTime(1960, 1, 1))
                return JeuneTemplate;
            return VieuxTemplate;
        }
    }
}
