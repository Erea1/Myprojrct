/******************************************
 * 扩展模块配置文件
 * 导入模块数据包后，激活对应模块
 * （取消对应模块 #define 前的注销符号即可）
 * ****************************************
 */

//#define UILaunchPanel
//#define UILoginPanel
//#define UIMainMenuPanel

#if UILaunchPanel
using VRCTP.IUILaunchPanel;
#endif

#if UILoginPanel
using VRCTP.IUILoginPanel;
#endif

#if UIMainMenuPanel
using VRCTP.IUIMainMenuPanel;
#endif

namespace QFramework {
    public partial class QMgrID {
        public const int UILaunchPanel = (FrameworkMsgModuleCount + 1) * QMsgSpan.Count;
        public const int UILoginPanel = (FrameworkMsgModuleCount + 2) * QMsgSpan.Count;
        public const int UIMainMenuPanel = (FrameworkMsgModuleCount + 3) * QMsgSpan.Count;
        public const int UISceneChooicePanel = (FrameworkMsgModuleCount + 4) * QMsgSpan.Count;

    }

    public partial class QMsgCenter {
        public static void ForwardMsg(QMsg msg) {
            switch (msg.ManagerID) {
#if UILaunchPanel
                case QMgrID.UILaunchPanel:
                    UILaunchPanelManager.Instance.SendMsg(msg);
                    break;
#endif
#if UILoginPanel
                case QMgrID.UILoginPanel:
                    UILoginPanelManager.Instance.SendMsg(msg);
                    break;
#endif
#if UIMainMenuPanel
                case QMgrID.UIMainMenuPanel:
                    UIMainMenuPanelManager.Instance.SendMsg(msg);
                    break;
#endif
            }
        }
    }
}