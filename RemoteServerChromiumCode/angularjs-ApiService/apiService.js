///This is the service that is going to talk to all windows forms

app.service('apiService', function ($http, $q, $rootScope, dummyEndPointService, $timeout) {
    /// <summary>
    /// This is the only service that will talk to the winforms or endpoint. This is one single service in the entire module that will do all the business logics.
    /// </summary>
    /// <param name="$http"></param>
    /// <param name="$q"></param>

    var servers = [];

    this.getAllServers = function() {
        /// <summary>
        ///  Gets all servers from api. This then sets the servers to $rootScope.servers
        /// </summary>
        var deferred = $q.defer();
        $timeout(function () {
            servers = dummyEndPointService.servers;
            var isSuccessful = false;
            if (servers.length > 0) {
                isSuccessful = true;
                $rootScope.servers = servers;
                $rootScope.$broadcast('initComplete', { message: 'Servers have been loaded successfully.' });
            } else {
                $rootScope.$broadcast('initFailed', { message: 'Servers could not be loaded.' });
            }
            deferred.resolve(isSuccessful);
        }, 2500);
        return deferred.promise;
    };


    $timeout(function() {
        if (servers.length > 0) {
            //do the following
            for (var server in servers) {
                
            }
            //for each server, get the 
        }
    },1000);


});

app.service('dummyEndPointService', function () {
    this.servers = [
        {
            name: 'srvparabcd07',
            id: 1,
            friendlyName: 'DEV PRE',
            description: ''
        }, {
            name: 'srvcldabcd001',
            id: 2,
            friendlyName: 'DEV POST',
            description: ''
        },
        {
            name: 'srvparabch01',
            id: 3,
            friendlyName: 'HOM Pre',
            description: ''
        },
        {
            name: 'srvparabch02',
            id: 4,
            friendlyName: 'HOM PRE2',
            description: ''
        },
        {
            name: 'srvcldabcd003',
            id: 5,
            friendlyName: 'DEV POST 1',
            description: ''
        }, {
            name: 'srvcldabcd005',
            id: 6,
            friendlyName: 'DEV POST 2',
            description: ''
        }
    ];
});



/* Resources 
http://www.dotnet-tricks.com/Tutorial/angularjs/HM0L291214-Understanding-$emit,-$broadcast-and-$on-in-AngularJS.html
*/