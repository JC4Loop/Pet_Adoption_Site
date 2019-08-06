# Pet Adoption Site
Site uses two different master pages, one for staff and another for non staff.

#### View Pets
Page shows a table of all pets in the database.
User can use a dropdown list to change the order of representation by each attribute.
The name of the pet is a clickable link to proceed to 'Adopt Pet' page.

![screenshot](/screenshots/ViewPetSS.png)

#### Adopt Pet
Displays all details of selected pet.
User can enter their information, validation provided.
Once user has entered their details and selected 'continue to purchase' they are redirected to the 'Adoption Desposit' page

![screenshot](/screenshots/AdoptPetsSS.png)

#### Adoption Deposit
Users input details are show along with details of Pet.
User can go back to change details if needed.
User must enter an amount more than or equal to the minimum deposit.
Amout can be in british pounds, euros or romanian leu. If euros or leu is selected, amount will be converted to pounds.
If the minimum amount is met, the 'Complete Order' button will save date to the database, creating the adoption.
The user is redirected to the 'Confirm Page' which will show a message that either the adoption has been successfully completed or if there has been a problem saving the pet or customer details to the database.

![screenshot](/screenshots/AdoptionDeposit.png)

#### Hall of Fame
Shows all the adoptions where the deposit was more than the minimum required.
Ordered descending, highest deposits to lower.

![screenshot](/screenshots/HallOfFameSS.png)

#### Staff Login
Simply a page for a staff user to log in for added functionality of the 'View Adoption' page.
Once logged in as staff all pages will use the Staff master page to include navigation to View Adoption.

#### View Adoptions
This will display a table of all adoptions, if adoption has been terminated the date of termination is show.
User can choose to only view adoptions which have not been terminated.
From this page user can access 'Terminate Adoption' page.

![screenshot](/screenshots/ViewAdoptionsSS1.png)

![screenshot](/screenshots/ViewAdoptionsSS2.png)

#### Terminate Adoption
Shows a table of all active adoptions.
User can select an adoption to terminate by clicking on its ID.
This will result in further information of the adoption to be displayed below and a confirm button to confirm deletion.

![screenshot](/screenshots/TerminateAdoptionSS.png)