using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeelPlugins
{
    internal class HideStudioUI : HideUIAction
    {
        private string[] targets = new[] { "Canvas", "Canvas Object List", "Canvas Main Menu", "Canvas Frame Cap", "Canvas System Menu", "Canvas Guide Input", "Canvas Color", "Canvas Pattern", "QuickAccessBoxCanvas(Clone)", "KKPECanvas(Clone)" };
        private IEnumerable<Canvas> canvasList;
        private bool visible = true;

        public HideStudioUI()
        {
            canvasList = GameObject.FindObjectsOfType<Canvas>().Where(x => targets.Contains(x.name));
        }

        public override void ToggleUI()
        {
            visible = !visible;
            foreach(var canvas in canvasList.Where(x => x))
                canvas.gameObject.SetActive(visible);
        }
    }
}