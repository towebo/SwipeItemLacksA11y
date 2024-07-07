# SwipeItemLacsA11y
This MAUI project is a simple example that can be used to test and confirm the lack of accessibility of SwipeItem in a CollectionView when using screen reader on Android.


1. Compile an push the app to a device.
2. Start Android Accessibility/TalkBack.
3. Start the app.
4. Double tap on a list item and hold for about a second, then swipe left.
5. The SwipeItem should now be visible to the right.
6. Focus the button for the SwipeItem's command that Says "Tap me" by touching it or swipe right or left depending where on the screen you are.
7. The screen reader says "Tap twice to activate" or similar.
8. Double tap to execute the command.

The result is that nothing happens.

If you turn off the screen reader tapping the action button will show an alert.