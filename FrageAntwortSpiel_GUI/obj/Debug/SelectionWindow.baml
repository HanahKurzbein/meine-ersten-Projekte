   M S B A M L   `   `   `  ????P  LFrageAntwortSpiel_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FrageAntwortSpiel_GUIFrageAntwortSpiel_GUI  5   	   +    %FrageAntwortSpiel_GUI.SelectionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FrageAntwortSpiel_GUI     5   	     ? Title$  SelectionWindow??5   	   $	??720??5	   	   $
??1280??5
   	    ? WindowStyle$
 None=?5   	    ? WindowState$ 	Maximized=?5   	    ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?5   	    ? 	Resources 5         MyBorder ?? 
TargetType ?? Property ?? Value??%?   &	        ?? 5   
   " ??6!   .?5      ??  ? ??
 ? ???6+   ?? 5       ? ??
 ??  ?6,   ?? 5       ? ??$ 5q?60   ?? 5       ?@??CornerRadius$ 5??6-   5      5      .??5      ?? -   5        	 ??Name$	 BorderGridSelectionWindow??5      
???????._?5   
   ? .+?5      ?? -   5        $ 	 BorderLabelSelectionWindow??5      
????  ?$??0,1,0,11q?5      
 ?? CornerRadius$
 25??5      
?????? $??60??5!      $	??480??5"      $??Center=?5#      $	??Top=?5$      $??0,25,0,0q?5%      ._?5&      ?? -   5         ??Name$ LabelSelectionWindow??5&      $??Frage-Antwort-Spiel??5'      
?????? 
??? ???$??Ravie)?5*      $??32(?5+      $??Medium&?5,      $??Normal"?5-      $??15,0,0,0q?5.      5/      ?? 51      -   5         ??Name$# StackPanelGridSelectionWindow??51       ?? Orientation$ Vertical=?52      $	??400??53      $
??1150??54      $??Center=?55      $??Center=?56      $??0,0,0,50q?57      .+?58      ?? -   5        $"	 BorderListBoxSelectionWindow??58      $	??400??59   !   $
??1150??5:   !   
??? ???
????  ?$??5q?5=   !   $
 50??5>   !   ._?5?      ?? -   5         ??Name$ ListBoxSelectionWindow??5?      $	??350??5@      $
??1100??5A      
?????? 
???   ?$??Garamond)?5D      $??30(?5E      $??Black"?5F      5G      5H      5I      ?? 5K      -   5        $"	 BorderTextBoxSelectionWindow??5K      #??[  5L      $??45??5M      $
??1105??5N      $??Center=?5O      $??Bottom=?5P      $??	0,0,0,105q?5Q      ._?5R      ?? -   5         ??Name$ TextBoxSelectionWindow??5R      
?????? 
???   ?$??Garamond)?5U      $??30(?5V      $??Black"?5W      5X      ?? 5Z      -	   5        $%	 BorderLoadButtonSelectionWindow??5Z      #??[  5[      $??60??5\      $	??220??5]      $
??Left=?5^      $??Bottom=?5_      $??	10,0,0,10q?5`      ._?5a      ?? -
   5         ??Name$ LoadButtonSelectionWindow??5a      $??Einlesen??5b      $??Ravie)?5c      $??30(?5d      
??????  ? Cursor$
 Hand??5f      5g      5h      ?? 5j      -   5        $$	 BorderSaveButtonSelectedWindow??5j      #??[  5k      $??60??5l      $	??250??5m      $??Center=?5n      $??Bottom=?5o      $??
0,0,285,10q?5p      ._?5q      ?? -   5        $ SaveButtonSelectedWindow??5q      $??	Speichern??5r      $??Ravie)?5s      $??30(?5t      
?????? $
 Hand??5v      5w      5x      ?? 5z      -   5        $&	  BorderCancelButtonSelectedWindow??5z      #??[  5{      $??60??5|      $	??250??5}      $??Center=?5~      $??Bottom=?5      $??
285,0,0,10q?5?      ._?5?      ?? -   5        $  CancelButtonSelectedWindow??5?      $??	Verwerfen??5?      $??Ravie)?5?      $??30(?5?      
?????? $
 Hand??5?      5?      5?      ?? 5?      -   5        $%	 BorderExitButtonSelectionWindow??5?      #??[  5?      $??60??5?      $	??220??5?      $??Right=?5?      $??Bottom=?5?      $??	0,0,10,10q?5?      ._?5?      ?? -   5        $ ExitButtonSelectionWindow??5?      $??
Schließen??5?      $??Ravie)?5?      $??30(?5?      
?????? $
 Hand??5?      5?      5?      5?      5?      5?      