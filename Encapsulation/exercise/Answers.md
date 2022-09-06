The application is accesing methods of Bank that should be protected. There are some commented code to prevent errors, because the proper class won't allow us to access those methods and variables.

All the methods and variables are public, so can be changed without supervision.

So, the account number is now read only, and the reward is a constant.
And only the access methods are public now. This ensures that no one can change those values at random.
The formatting is more precise, too, since the constant is in all caps, the method has the "_". Finally, there is a "Display" instead of "Get" while displaying the balance, for clarity purposes, because the function does not return an structure od the account data for example, but only shows the money.