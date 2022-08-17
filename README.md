# Bug with CollectionView with Nested SwipeView under Windows

For https://github.com/dotnet/maui/issues/9423

* The MainViewModel loads, and populates the ObservableCollection, bound to the CollectionView.
* Navigate to the second page with the button
* Hit the close button on page two
* Unhandled Error thrown with no inner exception, and no stack trace.

&nbsp;

| Entry                  | Value                              |
|------------------------|:-----------------------------------|
| Operating System:      | Windows 11 21H2 Build 22000.795    |
| IDE:                   | Visual Studio 2022 Enterprise 17.3 |
| Framework Version:     | 6.0.400                            |
| Maui Version:          | 6.0.486                            |
| Maui Target Framework: | net6.0-windows10.0.19041.0         |
