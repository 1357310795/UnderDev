   M S B A M L   `   `   `  ���� I  ETelerikWpfApp1, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TelerikWpfApp1TelerikWpfApp1  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem      TelerikWpfApp1.MainWindow1   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     .localclr-namespace:TelerikWpfApp1     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  0sys&clr-namespace:System;assembly=mscorlib    � Title$,  &HandyDraw BlackBoard Ver. by Hikari✨��$	��600��$
��1000�� � Icon$ 项目1.ico�� � WindowState$ Normal=� � WindowStyle$ SingleBorderWindow=� � 	Resources    ListBoxItemStyle �� 
TargetType ! MaterialDesignToolRadioButton �� BasedOn��%%   &	        7  �� " 	�8   .�-   .��)  #MaterialDesignThemes.Wpf.DialogHost  -     Name$ MainDialogHost1��   
Identifier$ MainDialogHost1��.��  -   $ MainDialogHost2��$ MainDialogHost2��.��� -   	 �Name$	 MainGrid��.+��� -   
 ��Name$
 MainContentControl��� -   $	 	GridTools��$��Center=�$��Bottom=�$��172,0,173,15q� J� RenderTransformOrigin$ 0.5,0.5&�$��60��.+�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 3Q�$��0q�.���� -    ��Name$ listboxTools��$��Center=� �� Orientation$ 
Horizontal=�$��0q�$ 0.5,0.5&�z�V� .~��� �� �� T�  T� Y$ 0Q�.+�	� -    	�Name$ CursorRadioButton��#��[   d� 	IsChecked$ FalseY�
 � Tag$ Cursor�� 	� 	GroupName$ Tools��.��� $	��5,2q� � RowDefinitions �� �� .+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$��0��   Kind$ CursorDefault=�$��24��$��24���� $��Center=�$��1��$��移动��$��0,5,0,0q�$��14(�	� -	   $ SelectRadioButton��#��[  $ FalseY�$ select��$ Tools��.��� $	��5,2q� �� �� .+�  $��Center=�$��0��$ Select=�$��24��$��24���� $��Center=�$��1��$��选择��$��0,5,0,0q�$��14(�	� -
   $ PenRadioButton��#��[  $
 TrueY�$	 Pen��$ Tools��.��� $	��5,2q� �� �� .+�  $��Center=�$ 
LeadPencil=�$��24��$��24���� $��Center=�$��1��$��标注��$��0,5,0,0q�$��14(�'  !MaterialDesignThemes.Wpf.PopupBox  -     Name$ PenSettingPopup��   	StaysOpen . {�. $��2��   PlacementMode$ TopAndAlignLeftEdges=�   PopupHorizontalOffset$ -5Q�   PopupVerticalOffset$ 40Q���Z�    ToggleContent Z�    PopupContent. #   TelerikWpfApp1.PenSettingMenu  -     Name$ 
PenSetting��	� -   $ MarkerRadioButton��#��[  $ FalseY�$ Marker��$ Tools��.��� $	��5,2q� �� �� .+�  $��Center=�$ Marker=�$��Center=�$��24��$��24���� $��Center=�$��1��$��	荧光笔��$��0,5,0,0q�$��14(�  -   $ MarkerSettingPopup�� . {�. $��2��$ TopAndAlignLeftEdges=�$ -5Q�$ 40Q���Z�  Z� . &    TelerikWpfApp1.MarkerSettingMenu  -     Name$ MarkerSetting��	� -   $ EraserRadioButton��#��[  $ FalseY�$ Eraser��$ Tools��.��� $	��5,2q� �� �� .+�  $��Center=�$ Eraser=�$��24��$��24���� $��Center=�$��1��$��擦除��$��0,5,0,0q�$��14(�  -   $ EraserSettingPopup�� . {�. $��2��$ TopAndAlignLeftEdges=�$ -5Q�$ 40Q���Z�  Z� . &    TelerikWpfApp1.EraserSettingMenu  -     Name$ EraserSetting��	� -   #��[  $ FalseY�$
 Save��$
 Save��.��� $	��5,2q� �� �� .+�  $��Center=�$ ContentSave=�$��24��$��24���� $��Center=�$��1��$��保存截图��$��0,5,0,0q�$��14(�  -   $ SaveSettingPopup�� . {�. $��2��$ TopAndAlignLeftEdges=�$ -5Q�$ 40Q���Z�  Z� . $   TelerikWpfApp1.SaveSettingMenu  -      Name$  SaveSetting��	� -   #��[  $ FalseY�$ Setting��$ Setting��.��� $	��5,2q� �� �� .+�  $��Center=�$ Build=�$��24��$��24���� $��Center=�$��1��$��设置��$��0,5,0,0q�$��14(�  -   $ SettingPopup�� . {�. $��2��$ TopAndAlignLeftEdges=�$ -5Q�$ 40Q���Z�  Z� . #	   TelerikWpfApp1.CamSettingMenu	  -   ! 	 Name$! CameraSettingMenu1��� -   $	 MenuGrid��$
��Auto��$
��Left=�$	��Top=����� *ActualWidth+" �� ElementName$" listboxTools��# �� Mode$# OneWay=��� -   $ NotiStackPanel��$
��Auto��$
��Auto��$	��Top=�$��Right=�$��0,5,5,0q�$��1��� -   $	 GridLeft��$
��Left=�$��Bottom=�$��	15,0,0,15q�$ 0.5,0.5&�$��60��.+�  $ 3Q�$��0q�.���� -   $ listboxLeft��$��Center=�$ 
Horizontal=�$��0q�$ 0.5,0.5&�z�V� .~��� �� �� T� $ 0Q�.+��� -     MaterialDesignFlatButton#��[ $��60��.��� $	��5,2q� �� �� .+�  $��Center=�$��0��$ WindowClose=�$��24��$��24��
���   ��� $��Center=�$��1��$��退出��$��0,5,0,0q�
���   �$��14(��� -   #��[ $��60��.��� $	��5,2q� �� �� .+�  $��Center=�$��0��$ WindowMinimize=�$��24��$��24��
���   ��� $��Center=�$��1��$��	最小化��$��0,5,0,0q�
���   �� -   $	 	GridRight��$��Right=�$��Bottom=�$��
15,0,15,15q�$ 0.5,0.5&�$��60��.+�  $ 3Q�$��0q�.���� -    $ listboxRight��$��Center=�$ 
Horizontal=�$��0q�$ 0.5,0.5&�z�V� .~��� �� �� T� $ 0Q�.+��� -!   #��[ $��60��.��� $	��0,2q�$��42�� �� �� .+�  $��Center=�$��0��$ KeyboardArrowLeft=�$��24��$��24��
���   ��� $��Center=�$��1��$��	上一页��$��0,5,0,0q�
���   �$��14(�� $��
10,0,10,-1q� �� �� .+��� -"   $ ��Name$$ TextPage��$��Center=�$��0��$	��1/1��$��0,10,0,0q�
���   �$��16(��� $��Center=�$��1��$��页码��$��0,5,0,0q�
���   �$��14(��� -#   #��[ $��60��.��� $	��0,2q�$��42�� �� �� .+�  -$   %  Name$% PageControlNextIcon��$��Center=�$��0��$	 Add=�$��24��$��24��
���   ��� -%   $$ PageControlNextText��$��Center=�$��1��$��加页��$��0,5,0,0q�
���   �� -&   $
	 Logo��$
��Left=�$	��Top=�$��10q�$ 0.5,0.5&�.+��� $��logo.png��$��30��$	��267��& J� Opacity$	& 0.2Q�' J� IsHitTestVisible' .  � -'   $	 InitPage��$y�Hidden=���!� ( j� 
AlignmentX$
( Left=�) j� 
AlignmentY$	) Top=�* j� Stretch$
* None=�+ j� ViewboxUnits$+ Absolute=�, !� Visual, �� -(   - ��Name$- 
BackCanvas��$
��1920��$
��1080�����	#FFFFCCCC �� $
��0.5* ��� $
��1.4* ��� $
��0.3* ��� $��2* ��� $��1* �.+��� $��请选择背景色。��$��1��$��Center=�$��Center=�$��72(�$��DengXian Light)�
�������� $��3��. � ColumnDefinitions. �� $��2* ��� $��3* ��� $��3* ��� $��3* ��� $��2* �.+��� -)   / ��Name$/ BlackBG�� # MaterialDesignRaisedLightButton#��[ +
  %MaterialDesignThemes.Wpf.ButtonAssist0 
  CornerRadius$0 10��+  %MaterialDesignThemes.Wpf.ShadowAssist1   ShadowDepth$1 Depth3=�$��1��$
��Auto��$��20q�
���   ���Z� .���  �� �� .+��� $��0��$	��黑�����	#FFFFFFFF$��DengXian Light)�$��72(�$��Center=��� $��1��$��#000000�����	#FFFFFFFF$��DengXian Light)�$��72(�$��0,40,0,0q��� -*   $/ GreenBG��#��[ $0 10��$1 Depth3=�$��2��$
��Auto��$��20q����	#FF1F2F1F��Z� .���  �� �� .+��� $��0��$��墨绿�����	#FFFFFFFF$��DengXian Light)�$��72(�$��Center=��� $��1��$��#1F2F1F�����	#FFFFFFFF$��DengXian Light)�$��72(�$��0,40,0,0q��� -+   $/ WhiteBG��#��[ $0 10��$1 Depth3=�$��3��$
��Auto��$��20q�
���������Z� .���  �� �� .+��� $��0��$	��白�����	#FF000000$��DengXian Light)�$��72(�$��Center=��� $��1��$��#FFFFFF�����	#FF000000$��DengXian Light)�$��72(�$��0,40,0,0q��� $ 
Horizontal=�$
��Left=�$	��Top=�$y�	Collapsed=�.+��� -,   $$ t1��$��60�� 	 speed#���  $��20(�
�������� --   2 �Name$2 p1��$	��500��$��20��3 � Maximum$	3 500Q�  speedint4 � Value#4 �  