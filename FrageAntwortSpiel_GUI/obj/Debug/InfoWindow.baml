   M S B A M L   `   `   `  ????P  LFrageAntwortSpiel_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FrageAntwortSpiel_GUIFrageAntwortSpiel_GUI  5   	   &     FrageAntwortSpiel_GUI.InfoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FrageAntwortSpiel_GUI     5   	     ? Title$  
InfoWindow??5   	   $	??720??5	   	   $
??1280??5
   	    ? WindowStyle$
 None=?5   	    ? WindowState$ 	Maximized=?5   	    ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?5   	    ? 	Resources 5         MyBorder ?? 
TargetType ?? Property ?? Value??%?   &	        ?? 5   
   " ??6!   .?5      ??  ? ??
 ? ???6+   ?? 5       ? ??
 ??  ?6,   ?? 5       ? ??$ 5q?60   ?? 5       ?@??CornerRadius$ 5??6-   5      5      .??5      ?? -   5        	 ??Name$	 BorderGridInfoWindow??5      
???????._?5   
   ? .+?5      ?? -   5        $	 BorderLabelInfo??5      
????  ?$??0,1,0,11q?5      
 ?? CornerRadius$
 25??5      
?????? $??60??5!      $	??480??5"      $??Center=?5#      $	??Top=?5$      $??0,25,0,0q?5%      ._?5&      ?? -   5         ??Name$ 	LabelInfo??5&      $??1??5'      $??Frage-Antwort-Spiel??5(      
?????? 
??? ???$??Ravie)?5+      $??32(?5,      $??Medium&?5-      $??Normal"?5.      $??15,0,0,1q?5/      50      ?? 52      -   5         ??Name$ StackPanelInfo??52       ?? Orientation$ Vertical=?53      $	??450??54      $
??1000??55      $??Center=?56      $??Center=?57      .+?58      ?? -   5        $	 
BorderInfo??58      $	??450??59   !   $
??1000??5:   !   
??? ???
????  ?$??5q?5=   !   $
 50??5>   !   ._?5?      ?? -   5         ??Name$ ListBoxInfo??5?      $	??400??5@   #   $	??950??5A   #   
?????? 
????  ?$??Ravie)?5D   #   $??20(?5E   #   5F      5G      ?? 5I      -   5        $	 BorderExitButtonInfo??5I      #??[  5J      $??60??5K      $	??220??5L      $??Right=?5M      $??Bottom=?5N      $??	0,0,10,10q?5O      ._?5P      ?? -   5         ??Name$ ExitButtonInfo??5P      $??
Schließen??5Q      $??Ravie)?5R      $??30(?5S      
??????  ? Cursor$
 Hand??5U       ?? IsCancel . 5V      5W      5X      5Y      5Z      