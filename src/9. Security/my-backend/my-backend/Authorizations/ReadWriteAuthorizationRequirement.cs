using Microsoft.AspNetCore.Authorization;

namespace my_backend.Authorizations
{
    public class ReadWriteAuthorizationRequirement : IAuthorizationRequirement
    {

    }

    public class MyCast
    {
        public object Name { get; set; } = null;
    }

    public class ReadWriteAuthorizationHandler : AuthorizationHandler<ReadWriteAuthorizationRequirement>
    {
        public ReadWriteAuthorizationHandler(IHttpContextAccessor logger)
        {

        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ReadWriteAuthorizationRequirement requirement)
        {
            if (!context.User.HasClaim("permissions", "Weathers:Read"))
                context.Succeed(requirement);
            else
                context.Fail(new AuthorizationFailureReason(this, "Pas le droit de read"));


            return Task.CompletedTask;
        }
    }
}
