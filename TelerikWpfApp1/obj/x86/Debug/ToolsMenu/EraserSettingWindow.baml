   M S B A M L   `   `   `  ����I  ETelerikWpfApp1, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TelerikWpfApp1TelerikWpfApp1  5   	   (    "TelerikWpfApp1.EraserSettingWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TelerikWpfApp1     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  64   -   5          � Topmost  .  � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6    � Title$ Window2��5
   	   $��279.2��6   $	��305��6(   ��5      Z� '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ -1q�6   .��5      ��  �� Orientation$ Vertical=�6   $��10q�6(   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��5         PrimaryHueMidBrush#���   5       ! PrimaryHueDarkForegroundBrush#���  5      $	��100��5      $��40��6      UniformCornerRadius$ 6Q�5      $
��Left=�5      $	��Top=�5      $��5,0,0,0q�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      $��20(�6B   z�5      �� 5      -   5        MyScaleTransform1��	 �� ScaleX$	 1Q�5   <   
 �� ScaleY
 6G   �� *ScaleX+ �� ElementName$ MyScaleTransform1�� J� RenderTransformOrigin$ 0.5,1&�5   i   .��5      �� $
��Wrap=�6   $��Center=�6,   $��Center=�6I   $��20(�6d   $��Microsoft YaHei UI Light)�6r   擦除选项5      5         5!   
   $��0��5"      $
��Auto��5#      $
��Auto��6   $ 6Q�5$      $
��Left=�5%      $	��Top=�5&      $��5,10,0,0q�5'      
�������$ Depth3=�5(      $��20(�6B   z�5)      �� 5*      -   5        MyScaleTransform2��$	 1Q�5*   <   
 6G   �� *ScaleX+$ MyScaleTransform2��$ 0.5,1&�5,   i   .��5-      � $��5q�6    � ColumnDefinitions 5.      �� 5/      $��1* �6'   �� 50      $��1* �6'   .+�52      �� -   5        $��0��52      $	��132��6)     MaterialDesignFlatButton#��[ 53      $
��Left=�54      $��20(�60   $��5q�6>   ��52   5   �� *ActualWidth+ �� Mode$ OneWay=� �� RelativeSource �� *Self+.��55   *   按笔画擦除57      �� 58      -   5        $��1��58      $	��132��6)    " MaterialDesignRaisedDarkButton#��[ 59      $
��Left=�5:      $��20(�60   $��5q�6>   ��58   5   �� *ActualWidth+$ OneWay=� �� *Self+.��5:   `   按点擦除5<      5=      5>      �� 5?   
   $ Vertical=�6   $��0,10,0,0q�6,   z�5@      �� 5A      -   5        MyScaleTransform3��$	 1Q�5A   <   
 6G   �� *ScaleX+$ MyScaleTransform3��$ 0.5,1&�5C   W   .+�5D      �� -   5        $	��280��5D      $��40��6!    $  MaterialDesignRaisedAccentButton#��[ 5E      $
��Left=�5F      $��20(�60   $��5q�6>   .��6`   擦除全部笔迹5H      5I      5J      5K      