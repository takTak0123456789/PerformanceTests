using Bogus;
using LegacyLib.Dto;

namespace LegacyLib
{
    public class FakeDataProvider : Singleton<FakeDataProvider>
    {
        public RequestDto GetRequest()
        {

            var random = new Bogus.Randomizer();
            var lorem = new Bogus.DataSets.Lorem();

            var subRequest = new Faker<SubRequestDto>()
                            .RuleFor(first => first.Name, f => lorem.Text())
                            .RuleFor(first => first.ChildID, f => random.Number(1990, 2030))
                            .RuleFor(first => first.DateOfBirth, f => f.Date.Recent(100));

            var requestDto = new RequestDto()
            {
                Year = random.Number(1990, 2030),
                Denomination1 = lorem.Text(),
                Denomination2 = lorem.Text(),
                MaritalStatus = random.Word(),
                SubRequests = subRequest.Generate(2),
                Income = (decimal)random.Number(10000, 2564789),
                QualifiedProp = (decimal)random.Number(10000, 2564789),
                QualifiedProp2 = (decimal)random.Number(10000, 2564789),
                SomeProp = (decimal)random.Number(10000, 2564789),
                SomeProp2 = (decimal)random.Number(10000, 2564789),
                SomeProp3 = (decimal)random.Number(10000, 2564789),
                Shortname = random.Word(),
                SomeProp22 = random.Word(),

            };

            return requestDto;

        }

        public Result GetResult()
        {
            var random = new Bogus.Randomizer();
            return new Result()
            {
                Prop1 = (decimal)random.Number(10000, 2564789),
                Prop2 = (decimal)random.Number(10000, 2564789),
                Prop3 = (decimal)random.Number(10000, 2564789),
                Prop4 = (decimal)random.Number(10000, 2564789),
                Prop5 = (decimal)random.Number(10000, 2564789),
            };
        }
    }
}
