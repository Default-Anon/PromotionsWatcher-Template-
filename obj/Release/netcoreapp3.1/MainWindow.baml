   M S B A M L   `   `   `  ���� E  ATradingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TradingApp
TradingApp      TradingApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TradingApp     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=null;mdw1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStyle$
  None=� � 
ResizeMode$ CanResizeWithGrip=� � AllowsTransparency$
 True�� � Title$ 
MainWindow��$	��650��$
��1100��.��� 
���   � � ColumnDefinitions �� $	��200���� $��* � � RowDefinitions �� $��30 ��� $��* �.+�� -   $��2��$��1��$��0��
���   �.+���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -    ��Name$
 Clip��$��30��$
��40,0q�$��30��
���   �
���   �.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	Paperclip=�
��� ����� -   $ Update��$��30��$��30��
���   �
���   �.��  $ Update=�
��� ����� -   $ UnShow��$��--��$��Center=�$��17(�
����  �$��30��$��30��
���   �
���   ��� -   $ 	Power_OFF��$��30��$��30��
���   �
���   �.��  $ Power=�
���  ��� $��0��$��0��.+��� $��TemplateAPP��
�������$��18(�$��Center=��� $��1��.���� $��0��
���   �$��1��.+��� $��0��$��1��$��17(�$��20q�
�������$��Center=�.��� $	��150��.+�  $ Stocking=�$��Center=�$��22���� $��20(�$
��Left=�$��37,0,0,0q�$	��113��Stocks�� -   
�������$��8q�
���   �$��16(�.��� $	��165��.+�  $
��Left=�$ Gamepad=�$��Center=��� $��Right=�$��GameCompany��$��Center=��� 
�������$��16(�$��8q�
���   �.��� $	��165��.+�  $
��Left=�$ OilLevel=�$��Center=��� $��Right=�$��ResourcesCompany��$��Center=��� 
�������$��16(�$��8q�
���   �.��� $	��165��.+�  $
��Left=�$ Water=�$��Center=��� $��Right=�$��UtilitiesCompany��$��Center=��� -   $ Communication��
�������$��16(�$��8q�
���   �.��� $	��165��.+�  $
��Left=�$ Phone=�$��Center=��� $
��Left=�$��Communication��$��Center=�$��49,0,0,0q�$	��116���� 
�������$��16(�$��8q�
���   �.��� $	��165��.+�  $
��Left=�$ Dollar=�$��Center=��� $
��Left=�$��Commercial services��$��Center=�$��21,0,0,0q�$	��144���� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ TruckDelivery=�$��Center=��� $
��Left=�$��Distribution��$��Center=�$��81,0,0,0q�$��86���� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ Electricity=�$��Center=��� $
��Left=�$��Electronic Tech��$��Center=�$��60,0,0,0q�$	��115���� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ RockClimbing=�$��Center=��� $
��Left=�$��Energy and Mineral��$��Center=�$��28,0,0,0q�$	��141���� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ Money=�$��Center=��� $
��Left=�$��FinanceCompany��$��Center=�$��45,1,0,0q��� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ Medicine=�$��Center=��� $
��Left=�$��Medical Tech��$��Center=�$��74,1,0,0q��� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ TruckDelivery=�$��Center=��� $
��Left=�$��Production and Tech��$��Center=�$��20,1,0,0q��� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ 
Industrial=�$��Center=��� $
��Left=�$��IndustrialProduction��$��Center=�$��21,0,0,0q�$	��144���� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$ 	Trademark=�$��Center=��� $
��Left=�$��Retail��$��Center=�$��	115,1,0,0q��� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$	 Car=�$��Center=��� $
��Left=�$��	Transport��$��Center=�$��95,1,0,0q��� 
�������$��16(�$��8q�
���   �.��� $	��175��.+�  $
��Left=�$	 And=�$��Center=��� $
��Left=�$��Other��$��Center=�$��	115,1,0,0q�� $��2��$��1��$��1��.+��� .���� -   	 ��Name$	 OtherStackPanel��