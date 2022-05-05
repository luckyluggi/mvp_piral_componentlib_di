# MVP to show an error with di in referenced Razor Component Libs

## Folders
- app-shell: a standard app-shell
- my-pilet: a blazor pilet
- component-lib: a Razor Class Library which serves as Component Library

## Repro Steps
- cd into `app-shell` and build it via `npm run build`
- cd into `my-pilet` and run `dotnet build`
- cd into the newly generated `piral~/my-pilet` and run npm start
- Now you see the startimngh page with Links to 2 Pages
  - The page `/working-example` shows a button. When The button is clicked a method from an injected IConsoleMessageService (from inside the razor class lib) is called. This method logs a message to the console.
  - The page `/failing-example` should have the same functionallity, but is setup differently. Here a MyButton (from inside the razor class lib) is shown. This button also injects the IConsoleMessageService and calls the same method. But this example only shows errors in the Browsers console.

So it seems that components from the Razor Class Library cannot inject dependencies that have been registered in the pilet.

## Things i already tried
- I already tried registring the Services in `ConfigureServices` and `ConfigureShared`  but this does not change anything
- I already tried adding a reference to Piral.Utils in the component-lib and adding the `@attribute [PiralComponent]` Attribute to the MyButton component, but this did not change anything. (this can b seen in the branch `try_with_piral_attribute`)