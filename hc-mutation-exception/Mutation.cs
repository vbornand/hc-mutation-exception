using System;

namespace hc_mutation_exception
{
    public class Mutation
    {
        public TestMutationPayload Test()
        {
            throw new Exception("Error");
        }
    }

    public class TestMutationPayload
    {
        public Test Test { get;set;}
    }

    public class Test
    {
        public string Foo { get; set; } = "Foo";
        public string Bar { get; set; } = "Bar";
    }
}