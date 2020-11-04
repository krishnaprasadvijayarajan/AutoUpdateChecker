<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        

        <meta name="description" content="Upload files and make them available for your friends. Think of it as Pastebin for files. Registration is not required. Large files are supported.">
        <meta name="author" content="Espen Braastad">
        <link rel="icon" href="https://filebin.net/static/img/favicon.png">

        <title>Filebin :: bin wck2mbisdhfsk9xq</title>

        
        <link rel="stylesheet" href="https://filebin.net/static/bootstrap/css/bootstrap.min.css"/>
        <link rel="stylesheet" href="https://filebin.net/static/css/upload.css"/>
        <link rel="stylesheet" href="https://filebin.net/static/css/custom.css"/>
        <link rel="stylesheet" href="https://filebin.net/static/css/font-awesome.css"/>

        <script src="https://filebin.net/static/js/jquery.js"></script>
        <script src="https://filebin.net/static/js/showhide.js"></script>
        <script src="https://filebin.net/static/js/upload.js"></script>
        <script src="https://filebin.net/static/js/sorttable.js"></script>
        <script src="https://filebin.net/static/js/popper.min.js"></script>
        <script src="https://filebin.net/static/bootstrap/js/bootstrap.min.js"></script>

        <script>
            window.onload = function () {
                if (typeof FileReader == "undefined") alert ("Your browser \
                    is not supported. You will need to update to a modern \
                    browser with File API support to upload files.");
                var fileCount = document.getElementById("fileCount");
                var fileList = document.getElementById("fileList");
                var fileDrop = document.body;
                var fileField = document.getElementById("fileField");
                var bin = "wck2mbisdhfsk9xq";
                var uploadURL = "https:\/\/filebin.net/";
                var binURL = "https:\/\/filebin.net/wck2mbisdhfsk9xq";
                FileAPI = new FileAPI(
                    fileCount,
                    fileList,
                    fileDrop,
                    fileField,
                    bin,
                    uploadURL,
                    binURL
                );
                FileAPI.init();
                
                fileDrop.ondrop = FileAPI.uploadQueue;
                
                fileField.addEventListener("change", FileAPI.uploadQueue)
            }
        </script>
    </head>

    <body id="fileDrop">
        <div class="container-fluid">

            
            <div class="row">
                <div class="col-sm-6">
                    <h1 class="display-2">
                        Filebin
                    </h1>
                </div>
                <div class="col-sm-6">
                    <div class="pull-right">
                        <p>
                            <small class="text-muted pull-right">
                                
                                    This bin contains 1 file.
                                
                                <br/>
                                
                                    Last updated 7 minutes ago.
                                    <br/>
                                
                                
                                    Expires 1 week from now
                                    <a href="" style="text-decoration: none;" data-toggle="modal" data-target="#expiration"><i class="fa fa-question-circle"></i></a>.
                                
                            </small>
                        </p>
                    </div>
                </div>
            </div>

            <ul class="nav nav-pills">
                <li class="nav-item">
                    <a class="nav-link btn btn-primary" href="" data-toggle="modal" data-target="#archive">
                        <i class="fa fa-cloud-download"></i> Download files
                    </a>
                </li>

                
                

                <li class="nav-item dropdown">
                    <a class="nav-link dropdown" href="" id="dropdown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">More <i class="fa fa-caret-down"></i></a>

                    <div class="dropdown-menu dropright" aria-labelledby="dropdown">

                        <span class="dropdown-item fileUpload">
                            <span>
                                <i class="fa fa-fw fa-cloud-upload text-primary"></i> Upload more files
                            </span>
                            <input type="file" class="upload" id="fileField" multiple>
                        </span>

                        <a class="dropdown-item" href="" data-toggle="modal" data-target="#info">
                            <i class="fa fa-fw fa-info-circle text-primary"></i> Bin properties
                        </a>

                        <div class="dropdown-divider"></div>

                        <a class="dropdown-item" href="" data-toggle="modal" data-target="#delete">
                            <i class="fa fa-fw fa-trash text-danger"></i> Delete bin
                        </a>

                        <div class="dropdown-divider"></div>

                        <a class="dropdown-item" href="https://filebin.net">
                            <i class="fa fa-fw fa-plus text-success"></i> New bin
                        </a>
                    </div>
                </li>
            </ul>

            
            <span id="fileList"></span>

            
            <div id="fileCount"></div>

            
            

            
            
                <table class="sortable table">
	            <thead class="thead-light">
                        <tr>
                            <th>
                                <i class="fa fa-bin"></i> Filename
                            </th>
                            <th class="hidden-xs-down">
                                <i class="fa fa-database"></i> Size
                            </th>
                            <th class="hidden-sm-down">
                                <i class="fa fa-clock-o"></i> Uploaded
                            </th>
                            
                            <th class="sorttable_nosort"></th>
                        </tr>
	            </thead>
	            <tbody>
                        
                            <tr>
                                <td>
                                    
                                    <i class="fa fa-fw fa-file-o"></i>
                                    

                                    
                                    <a href="https://filebin.net/wck2mbisdhfsk9xq/README.txt?t=hbiaqr8k">README.txt</a>
                                </td>
                                <td class="hidden-xs-down" sorttable_customkey="5">
                                    5 B
                                </td>
                                <td class="hidden-sm-down" sorttable_customkey="2020-11-01 11:11:08.95310651 &#43;0000 UTC">
                                    7 minutes ago
                                </td>
                                

                                <td>
                                    <div class="pull-right">
                                        <div class="dropdown">
                                            <a href="" class="small" id="dropdown-0" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" style="text-decoration: none;">More <i class="fa fa-caret-down"></i></a>
                                            <div class="dropdown-menu dropdown-menu-right" aria-labelledby="dropdown-0">
                                                

                                                <a class="dropdown-item" href="" data-toggle="modal" data-target="#info-0">
                                                    <i class="fa fa-fw fa-info-circle text-primary"></i> File properties
                                                </a>

                                                <div class="dropdown-divider"></div>
                                    
                                                <a class="dropdown-item" href="" data-toggle="modal" data-target="#delete-0">
                                                    <i class="fa fa-fw fa-trash text-danger"></i> Delete file
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        
	            <tbody>
                </table>
            
        </div>

        
        
            
            <div class="modal fade" id="info-0" tabindex="-1" role="dialog" aria-labelledby="info-0" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header alert-secondary">
                            <h5 class="modal-title">File properties</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>

                        <div class="modal-body">
                            
                            
                            

                            <ul class="dl-horizontal">
                                <dt class="col">Filename</dt>
                                <dd class="col">
                                    
                                    <a href="https://filebin.net/wck2mbisdhfsk9xq/README.txt?t=hbiaqr8k">
                                        README.txt
                                    </a>
                                </dd>

                                <dt class="col">Bin</dt>
                                <dd class="col">
                                    
                                    <a href="https://filebin.net/wck2mbisdhfsk9xq">
                                        wck2mbisdhfsk9xq
                                    </a>
                                </dd>

                                <dt class="col">Size</dt>
                                <dd class="col">
                                    5 B
                                    (5 bytes)
                                </dd>

                                <dt class="col">MIME</dt>
                                <dd class="col">
                                    application/octet-stream
                                </dd>

                                

                                

                                <dt class="col">Uploaded</dt>
                                <dd class="col">
                                    7 minutes ago (2020-11-01 11:11:08 UTC)
                                </dd>

                                <dt class="col">Expires</dt>
                                <dd class="col">
                                    
                                        1 week from now
                                    
                                    (2020-11-09 11:11:09 UTC)
                                </dd>
                            </ul>
                        </div>

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" aria-label="Close"><i class="fa fa-close"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
            
            
            <div class="modal fade" id="delete-0" tabindex="-1" role="dialog" aria-labelledby="delete-0" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header alert-secondary">
                          <h5 class="modal-title">Delete file</h5>
                          <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                          </button>
                        </div>
                        <div class="modal-body">

                            <p>You are free to delete any file in this bin. However you are encouraged to delete the files that you have uploaded only, or files with obvious malicious or illegal content. This action is not reversible.</p>

                            
                            <p class="lead">Delete the file <a href="https://filebin.net/wck2mbisdhfsk9xq/README.txt?t=hbiaqr8k">README.txt</a>?</p>

                            <div id="deleteStatus-0"></div>
                        </div>

                        <div class="modal-footer">
                            <div class="pull-left">
                            <button type="button" class="btn btn-danger" id="deleteButton-0" onclick="deleteURL('https:\/\/filebin.net/wck2mbisdhfsk9xq/README.txt', 'deleteStatus-0')"><i class="fa fa-trash-o"></i> Confirm</button>
                            </div>
                            <a href="https://filebin.net/wck2mbisdhfsk9xq" class="btn btn-secondary"><i class="fa fa-close"></i> Close</a>
                        </div>
                    </div>
                </div>
            </div>
            
        

        
        <div class="modal fade" id="expiration" tabindex="-1" role="dialog" aria-labelledby="expiration" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header alert-secondary">
                      <h5 class="modal-title">Expiration</h5>
                      <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                      </button>
                    </div>
                    <div class="modal-body">

                        <p>Bins are automatically expired after a period of time. Files inherit the expiration time from their bins.</p>

                        <p>Expired files are deleted and are no longer accessible. It is not possible to view or upload files to expired bins.</p>

                        <p>The expiration time of a bin is renewed whenever a file is uploaded, which means that bins can potentially be long lived if files are uploaded in intervals.</p>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal" aria-label="Close"><i class="fa fa-close"></i> Close</button>
                    </div>
                </div>
            </div>
        </div>
        
        
        <div class="modal fade" id="info" tabindex="-1" role="dialog" aria-labelledby="info" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header alert-secondary">
                      <h5 class="modal-title">Bin properties</h5>
                      <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                      </button>
                    </div>
                    <div class="modal-body">
                        <ul class="dl-horizontal">
                            <dt class="col">Bin</dt>
                            <dd class="col">
                                <a href="https://filebin.net/wck2mbisdhfsk9xq">
                                    wck2mbisdhfsk9xq
                                </a>
                            </dd>

                            <dt class="col">Files</dt>
                            <dd class="col">
                                1
                            </dd>

                            <dt class="col">Size</dt>
                            <dd class="col">
                                5 B
                                (5 bytes)
                            </dd>

                            <dt class="col">Last updated</dt>
                            <dd class="col">
                                7 minutes ago
                                (2020-11-01 11:11:08 UTC)
                            </dd>

                            <dt class="col">Expires</dt>
                            <dd class="col">
                                
                                    1 week from now
                                
                                (2020-11-09 11:11:09 UTC)
                            </dd>
                        </ul>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal" aria-label="Close"><i class="fa fa-close"></i> Close</button>
                    </div>
                </div>
            </div>
        </div>
        
        
        <div class="modal fade" id="delete" tabindex="-1" role="dialog" aria-labelledby="delete" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header alert-secondary">
                        <h5 class="modal-title">Delete bin</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <p>You are free to delete this bin. However you are encouraged to delete your own bins only, or bins that are being used to share obvious malicious or illegal content. This action is not reversible.</p>

                        <p class="lead">Delete all the files in bin <a href="https://filebin.net/wck2mbisdhfsk9xq">wck2mbisdhfsk9xq</a>?</p>

                        <div id="deleteStatus"></div>
                    </div>

                    <div class="modal-footer">
                        <div class="pull-left">
                        <button type="button" class="btn btn-danger" id="deleteButton" onclick="deleteURL('https:\/\/filebin.net/wck2mbisdhfsk9xq','deleteStatus')"><i class="fa fa-trash-o"></i> Confirm</button>
                        </div>
                        <a href="https://filebin.net/wck2mbisdhfsk9xq" class="btn btn-secondary"><i class="fa fa-close"></i> Close</a>
                    </div>
                </div>
            </div>
        </div>
        
        
        <div class="modal fade" id="archive" tabindex="-1" role="dialog" aria-labelledby="archive" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header alert-secondary">
                        <h5 class="modal-title">Download files</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <p>
                            The files in this bin can be downloaded as a single archive. The default filename of the archive is <code>wck2mbisdhfsk9xq</code> and the full size is 5 B.
                        </p>

                        <p class="lead">Select archive format to download:</p>

                        <ul class="nav nav-pills">
                            <li class="nav-item">
				
                                    <a class="nav-link btn-primary" href="https://filebin.net/archive/wck2mbisdhfsk9xq/tar?t=hbiaqr8k"><i class="fa fa-file-archive-o"></i> Tar</a>
				
                            </li>
                            <li class="nav-item">
				
                                    <a class="nav-link btn-primary" href="https://filebin.net/archive/wck2mbisdhfsk9xq/zip?t=hbiaqr8k"><i class="fa fa-file-archive-o"></i> Zip</a>
                                
                            </li>
                        </nav>
                    </div>

                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal" aria-label="Close"><i class="fa fa-close"></i> Close</button>
                    </div>
                </div>
            </div>
        </div>
        
        
    </body>
</html>
