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
The menu uses a top navigation bar to easily navigate between the 
categories on the menu and the different languages that are available. 

For the best practices to translate the menu, the language
choices are placed in the top right of the display for ease of access.

The menu inteface supports the right to left reading orientation of 
the Arabic language. 

Resx files are used for the fluid translation and localization of 
the menu items from one language to another. 

The conversion rates are fetched in real-time from the website, xe.com.

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

