using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.LineActions.ImageMap
{
    public abstract class ImageMapActionsBase: LineActionsBase
    {
        protected ImageMapActionsBase(ActionType type):base(type)
        {

        }  
        public ImageMapArea area { get; set; }
    }
}
