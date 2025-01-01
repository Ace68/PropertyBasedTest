# Property Based Testing
Property-based testing is an alternative approach that can deal with the shortcoming of example-based tests.  
Property-based testing is generative testing:
> - You do not supply specific example inputs with expected outputs as with example-based test
> - You define properties about the code and use a generative-testing engine (QuickCheck in Haskell, FsCheck in .NET) to create  
    randomized inputs to ensure the defined properties are correct

# How to apply Property-based testing?
> - Understand and represent the relationship between inputs and outputs
> - Use randomly generated inputs to express deterministics outputs
> - It's by no means a full replacement!
> - The best approach is to have the right mix of the two in your suite

# What is a Property?
We don't mean properties of C# classes.  
The term property is used in a more abstract way (charachteristics, trait, attribute, feature or quality of an algorithm).  
A property is a condition that will always be true for a set of valid inputs.  

