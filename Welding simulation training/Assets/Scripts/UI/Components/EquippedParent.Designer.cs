/****************************************************************************
 * 2020.4 MS-20190513ZPLV
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace VRCTP
{
	public partial class EquippedParent
	{
		[SerializeField] public CheckButton CheckButton;

		public void Clear()
		{
			CheckButton = null;
		}

		public override string ComponentName
		{
			get { return "EquippedParent";}
		}
	}
}
