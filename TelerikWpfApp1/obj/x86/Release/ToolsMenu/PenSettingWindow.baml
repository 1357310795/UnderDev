   M S B A M L   `   `   `  ���� I  ETelerikWpfApp1, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TelerikWpfApp1TelerikWpfApp1  %    TelerikWpfApp1.PenSettingWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:TelerikWpfApp1     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Topmost  .  � Title$ Window2��$��457.6��$	��390�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=���Z� '  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ -1q�.���� $	��370��$��10q�$��Bottom=�.+�#  MaterialDesignThemes.Wpf.Card  $��0��   PrimaryHueMidBrush#���    ! PrimaryHueDarkForegroundBrush#���  $	��100��$��40��   UniformCornerRadius$ 6Q�$
��Left=�$	��Top=�$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�$��20(�z��� -   MyScaleTransform1�� �� ScaleX$ 1Q�	 �� ScaleY	 �� *ScaleX+
 �� ElementName$
 MyScaleTransform1�� J� RenderTransformOrigin$ 0.5,1&�.���� $
��Wrap=�$��Center=�$��Center=�$��20(�$��Microsoft YaHei UI Light)�画笔设置  $	��370��$��98��$ 6Q�$
��Left=�$	��Top=�$��0,10,0,0q�$��5q�$ Depth2=�$��20(�
�������z��� -   MyScaleTransform2��$ 1Q�	 �� *ScaleX+$
 MyScaleTransform2��$ 0.5,1&�.����  �� Orientation$ Vertical=�.+��� $��笔尖��$��	15,10,0,0q�$��20(��� $ 
Horizontal=�$
��15,0q�.+�� $��50��$��50��$��2q�.+�A� -    A�Name$ StylusSizeEllipse��
���   ����� *Value+$
 StylusSizeSlider������ *Value+$
 StylusSizeSlider���� -    ��Name$ StylusSizeText��$��5q�$��Center=�$��14������ *Value+$
 StylusSizeSlider���� -    ��Name$ StylusSizeSlider�� �� Orientation$ 
Horizontal=� � Minimum$ 1Q� � Maximum$ 50Q� � Value$ 5Q�$	��200��$��5q�$��Center=� �� IsSnapToTickEnabled .   $	��370��$	��276��$ 6Q�$
��Left=�$	��Top=�$��0,10,0,0q�$��5q�$ Depth2=�$��20(�
�������z��� -   MyScaleTransform3��$ 1Q�	 �� *ScaleX+$
 MyScaleTransform3��$ 0.5,1&�.���� $ Vertical=�.+��� $��颜色��$��
15,10,10,0q�$��20(��� $ Vertical=�.+�� .+��� -    ��Name$ ColorRectangle��$	��333��$��25��$��Center=�  SecondaryAccentBrush#���  $
��10,0q��� $��当前颜色�����	#FF303030$��Center=�$��Center=�$��5q�$��18(��� -	    ��Name$ ColorTabControl��$ 0.5,0&�$	��450��$
��Auto��$��Center=�$��20(�����  �� 
TargetType" ��  MaterialDesignTabControl �� BasedOn# [  � LayoutTransform V� .~��� $	 0.8Q�$		 0.8Q��� �� T� .@��� $��MD标准色��$��12(�$ 0.5,0.5&�.���  � Orientation$ 
Horizontal=�$��10q�.+���  " MaterialDesignRaisedDarkButton#��[ $��56��$��56��$��2q�
���   ���Z� �� #��[ $��56��$��56��$��2q�
���������Z� �� #��[ $��56��$��56��$��2q����	#FF9E9E9E��Z� �� #��[ $��56��$��56��$��2q����	#FF567D8B��Z� �� #��[ $��56��$��56��$��2q����	#FF795648��Z� �� #��[ $��56��$��56��$��2q����	#FFFF9800��Z� �� #��[ $��56��$��56��$��2q����	#FFFFC107��Z� �� #��[ $��56��$��56��$��2q����	#FFF44336��Z� �� #��[ $��56��$��56��$��2q����	#FFFF5722��Z� �� #��[ $��56��$��56��$��2q����	#FFE91E63��Z� �� #��[ $��56��$��56��$��2q����	#FF9C27B0��Z� �� #��[ $��56��$��56��$��2q����	#FF673AB7��Z� �� #��[ $��56��$��56��$��2q����	#FF3F51B5��Z� �� #��[ $��56��$��56��$��2q����	#FFFFEB3B��Z� �� #��[ $��56��$��56��$��2q����	#FF03A9F4��Z� �� #��[ $��56��$��56��$��2q����	#FF2196F3��Z� �� #��[ $��56��$��56��$��2q����	#FF00BCD4��Z� �� #��[ $��56��$��56��$��2q����	#FF4CAF56��Z� �� #��[ $��56��$��56��$��2q����	#FF8BC34A��Z� �� #��[ $��56��$��56��$��2q����	#FFCDDC39��Z� �� #��[ $��56��$��56��$��2q����	#FF009688��Z� �� $��MSOffice标准色��$��8(�.��� $ 
Horizontal=�$��10q�.+��� #��[ $��36��$��36��$��1q�
���   ���Z� �� #��[ $��36��$��36��$��1q�
���������Z� �� #��[ $��36��$��36��$��1q����#ff0000��Z� �� #��[ $��36��$��36��$��1q����	#FFFFC000��Z� �� #��[ $��36��$��36��$��1q�
��� �����Z� �� #��[ $��36��$��36��$��1q����	#FF92D036��Z� �� #��[ $��36��$��36��$��1q����	#FF00B036��Z� �� #��[ $��36��$��36��$��1q����	#FF00B0F0��Z� �� #��[ $��36��$��36��$��1q����	#FF0070C0��Z� �� #��[ $��36��$��36��$��1q����	#FF002036��Z� �� #��[ $��36��$��36��$��1q����	#FF7036A0��Z� �� $��中国传统色��$��8(�.��� $ 
Horizontal=�$��10q�