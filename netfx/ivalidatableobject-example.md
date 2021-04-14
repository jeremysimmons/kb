Implementation
```csharp
public class ValidateMe : IValidatableObject
{
    [Required]
    public bool Enable { get; set; }

    [Range(1, 5)]
    public int Prop1 { get; set; }

    [Range(1, 5)]
    public int Prop2 { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        if (this.Enable)
        {
            Validator.TryValidateProperty(this.Prop1,
                new ValidationContext(this, null, null) { MemberName = "Prop1" },
                results);
            Validator.TryValidateProperty(this.Prop2,
                new ValidationContext(this, null, null) { MemberName = "Prop2" },
                results);

            // some other random test
            if (this.Prop1 > this.Prop2)
            {
                results.Add(new ValidationResult("Prop1 must be larger than Prop2"));
            }
        }
        return results;
    }
}
```

Usage
```csharp
public void DoValidation()
{
    var toValidate = new ValidateMe()
    {
        Enable = true,
        Prop1 = 1,
        Prop2 = 2
    };

    bool validateAllProperties = false;

    var results = new List<ValidationResult>();

    bool isValid = Validator.TryValidateObject(
        toValidate,
        new ValidationContext(toValidate, null, null),
        results,
        validateAllProperties);
}
```

Source: https://stackoverflow.com/a/3401178/26877