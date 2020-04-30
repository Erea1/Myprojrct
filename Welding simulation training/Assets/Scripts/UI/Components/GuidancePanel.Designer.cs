/****************************************************************************
 * 2020.4 MS-20190513ZPLV
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace VRCTP
{
	public partial class GuidancePanel
	{
		[SerializeField] public CloseButton CloseButton;

		public void Clear()
		{
			CloseButton = null;
		}

		public override string ComponentName
		{
			get { return "GuidancePanel";}
		}
	}
}
