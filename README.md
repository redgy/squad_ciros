# squad_ciros
# Team Members: Ruth Wu, Bonny Truong, Maggie Lee, and Redgy Canos

This Visual Basic Project utilizes concepts from SDSU's CS540 
Software Internationalization to generate an interactive menu 
for the Ciro's restaurant in downtown San Diego. The interactive 
menu is designed for ease of access to tourists wishing to read 
the menu in their selected language. This menu supports the 
following languages: English, Spanish, French, Arabic, and Mandarin. 

-----------------

Design Decisions: 

This menu uses a top navigation bar to easily navigate between the 
categories on the menu and the different languages that are available. 

For the best practices to seamlessly switch to a different language, 
the language choices are placed in the top right of the display for ease of access.

Based on the selection of the language, the resx files are used for the fluid 
translation and localization of the menu items from one language to another. 

The conversion rates are fetched in real-time from the website, xe.com. THe
rates of the menu items will change according to the language that is selected. 

-----------------

Notes:
This project loads a new form when clicking each category. It will 
always default to the English language, regardless if the user was
viewing the previous form in a different language. The developers
would like to fix this issue in the future. 

Another thing to note is the real-time conversion rates that are
calculated at the loading of each form. The developers would like
to optimize this in the future because it causes a time lag when 
clicking a category. 

The developers would like to deal with this issue in the future
and not at this time. The project is satisfactory in that it does
what it is supposed to do and is a decendtly working product. Also
due to time constraints, the developers decided to leave this 
project as it currently is.

The menu inteface currently does not support the right to left reading 
orientation for all of the Arabic sub menus. This is something that the
developers wish to implement in the future. Due to time constraints, this
feature has not yet been integrated. 

