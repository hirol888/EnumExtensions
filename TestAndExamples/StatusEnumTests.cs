using NUnit.Framework;
using EnumExtensions;

namespace TestAndExamples
{
  public class StatusEnumTests
  {
    [Test]
    public void Should_Get_All_Metadata()
    {
      StatusEnum okStatus = StatusEnum.OK;
      var code = okStatus.GetAttributeOfType<StatusEnumMetadata>()?.Code;
      var description = okStatus.GetAttributeOfType<StatusEnumMetadata>()?.Description;
      var color = okStatus.GetAttributeOfType<StatusEnumMetadata>()?.Color;
      var order = okStatus.GetAttributeOfType<StatusEnumMetadata>()?.Order;

      Assert.AreEqual("200", code);
      Assert.AreEqual("OK indicates that the request succeeded and that the requested information is in the response. This is the most common status code to receive.", description);
      Assert.AreEqual("#69f0ae", color);
      Assert.AreEqual(1, order);
    }

    [Test]
    public void Should_Get_Default_Value_For_Int_If_Not_Provided()
    {
      StatusEnum badRequest = StatusEnum.BadRequest;
      var order = badRequest.GetAttributeOfType<StatusEnumMetadata>()?.Order;

      Assert.AreEqual(0, order);
    }

    [Test]
    public void Should_Get_Null_For_String_If_Not_Provided()
    {
      StatusEnum badGateway = StatusEnum.BadGateway;
      var color = badGateway.GetAttributeOfType<StatusEnumMetadata>()?.Color;

      Assert.IsNull(color);
    }

    [Test]
    public void Should_Get_Nulls()
    {
      StatusEnum? nullStatus = null;
      var code = nullStatus.GetAttributeOfType<StatusEnumMetadata>()?.Code;
      var description = nullStatus.GetAttributeOfType<StatusEnumMetadata>()?.Description;
      var color = nullStatus.GetAttributeOfType<StatusEnumMetadata>()?.Color;
      var order = nullStatus.GetAttributeOfType<StatusEnumMetadata>()?.Order;

      Assert.IsNull(code);
      Assert.IsNull(description);
      Assert.IsNull(color);
      Assert.IsNull(order);
    }
  }
}