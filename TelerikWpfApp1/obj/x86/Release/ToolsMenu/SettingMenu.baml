   M S B A M L   `   `   `  ���� I  ETelerikWpfApp1, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TelerikWpfApp1TelerikWpfApp1  #    TelerikWpfApp1.CamSettingMenu   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:TelerikWpfApp1     a ]Telerik.Windows.Data, Version=2020.1.115.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2020.1.115.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2020.1.115.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2020.1.115.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Etelerik1http://schemas.telerik.com/2008/xaml/presentation     
�������$
��Auto��$	��221��$��8q�.���� $��5q�.+��� -     ��Name$  startCameraButton��$��启动摄像头��$��0 0 0 8q� "  MaterialDesignRaisedDarkButton#��[  {�.  �� -   $  stopCameraButton��$��关闭摄像头��#��[  $��0 0 0 8q��� .+��� $��视频设备:���� -    ��Name$ cameraDevicesComboBox�� �� DisplayMemberPath$ FriendlyName��$��0 2 0 8q��� .+��� $��视频格式:���� -   $ videoFormatsComboBox��$��0 2 0 8q����� .R��� �� ��� *FrameSizeWidth+ �� $�x�� �� ��� *FrameSizeHeight+ �� $�@�� �� ��� *EffectiveFrameRate+ �� Mode$ OneWay=� �� ��� *SubTypeDisplayName+$ OneWay=��� -   #��[  $��高级设置��