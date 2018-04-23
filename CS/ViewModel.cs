using System;

namespace DXSample {
    public class CategoryAttributesViewModel {
        public virtual Person Person { get; protected set; }
        public CategoryAttributesViewModel() {
            Person = new Person {
                FirstName = "Anita",
                LastName = "Benson",
                Address = new Address {
                    AddressLine1 = "9602 South Main",
                    AddressLine2 = "Seattle, 77025, USA",
                },
                Phone = "7138638137",
            };
        }
    }
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }
    public class Address {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}