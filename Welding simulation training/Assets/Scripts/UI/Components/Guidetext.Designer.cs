/****************************************************************************
 * 2020.4 DESKTOP-I056DAV
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace VRCTP
{
	public partial class Guidetext
	{
		[SerializeField] public UnityEngine.UI.Text Text;

		public void Clear()
		{
			Text = null;
		}

		public override string ComponentName
		{
			get { return "Guidetext";}
		}
	}
}
