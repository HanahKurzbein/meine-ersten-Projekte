   M S B A M L   `   `   `  ????P  LFrageAntwortSpiel_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FrageAntwortSpiel_GUIFrageAntwortSpiel_GUI  5   	   (    "FrageAntwortSpiel_GUI.DeleteWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FrageAntwortSpiel_GUI     5   	     ? Title$  DeleteWindow??5   	   $	??720??5	   	   $
??1280??5
   	    ? WindowStyle$
 None=?5   	    ? WindowState$ 	Maximized=?5   	    ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?5   	    ? 	Resources 5         MyBorder ?? 
TargetType ?? Property ?? Value??%?   &	        ?? 5   
   " ??6!   .?5      ??  ? ??
 ? ???6+   ?? 5       ? ??
 ??  ?6,   ?? 5       ? ??$ 5q?60   ?? 5       ?@??CornerRadius$ 5??6-   5      5      .??5      ?? -   5        	 ??Name$	 BorderGridDeleteWindow??5      
???????._?5   
   ? .+?5      ?? -   5        $	 BorderLabelDeleteWindow??5      
????  ?$??0,1,0,11q?5      
 ?? CornerRadius$
 25??5      
?????? $??60??5!      $	??480??5"      $??Center=?5#      $	??Top=?5$      $??0,25,0,0q?5%      ._?5&      ?? -   5         ??Name$ LabelDeleteWindow??5&      $??Frage-Antwort-Spiel??5'      
?????? 
??? ???$??Ravie)?5*      $??32(?5+      $??Medium&?5,      $??Normal"?5-      $??15,0,0,0q?5.      5/      ?? 51      -   5         ??Name$  StackPanelGridDeleteWindow??51       ?? Orientation$ Vertical=?52      $	??450??53      $
??1150??54      $??Center=?55      $??Center=?56      .+?57      ?? -   5        $ 	 BorderDataGridDeleteWindow??57      $	??450??58   !   $
??1150??59   !   
??? ???
????  ?$??5q?5<   !   $
 50??5=   !   ._?5>      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridDeleteWindow??5>      $	??400??5?      $
??1100??5@      
?????? 
???   ?$??Garamond)?5C      $??30(?5D      $??Black"?5E         HeadersVisibility$
 None=?5F         RowBackground
 ???? 5G      5H      5I      ?? 5K      -   5        $"	 BorderLoadButtonDeleteWindow??5K      #??[  5L      $??60??5M      $	??220??5N      $
??Left=?5O      $??Bottom=?5P      $??	10,0,0,10q?5Q      ._?5R      ?? -   5         ??Name$ LoadButtonDeleteWindow??5R      $??Einlesen??5S      $??Ravie)?5T      $??30(?5U      
??????  ? Cursor$
 Hand??5W      5X      5Y      ?? 5[      -	   5        $!	 BorderDelButtonDeleteWindow??5[      #??[  5\      $??60??5]      $	??250??5^      $??Center=?5_      $??Bottom=?5`      $??0,0,0,10q?5a      ._?5b      ?? -
   5        $ DelButtonDelWin??5b      $??Löschen??5c      $??Ravie)?5d      $??30(?5e      
?????? $
 Hand??5g      5i      5j      ?? 5l      -   5        $"	 BorderExitButtonDeleteWindow??5l      #??[  5m      $??60??5n      $	??220??5o      $??Right=?5p      $??Bottom=?5q      $??	0,0,10,10q?5r      ._?5s      ?? -   5        $ ExitButtonDeleteWindow??5s      $??
Schließen??5t      $??Ravie)?5u      $??30(?5v      
?????? $
 Hand??5x      5y      5z      5{      5|      5}      