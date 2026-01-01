
using ChainofResponsibility;

IRequestHandler auth = new AuthHandler();
IRequestHandler authorization  = new AuthorizationHandler();
IRequestHandler rateLimit = new RateLimitHandler();
IRequestHandler validation = new ValidationHandler();
IRequestHandler businessLogic = new BusinessLogicHandler(); 


// Build the Chain

auth.SetNext(authorization);
authorization.SetNext(rateLimit);
rateLimit.SetNext(validation);
validation.SetNext(businessLogic);


// Send a request through the chain
Request request = new Request("john", "ADMIN", 10, "{ \"data\": \"valid\" }");
auth.Handle(request);

