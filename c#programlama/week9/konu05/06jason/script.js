$(document).ready(function(){
    function loadPosts(){
        $.ajax({
            url:'https://jsonplaceholder.typicode.com/posts',
            method:'GET',
            success: function(posts){
                
                let postsHTML='';
                posts.forEach(post => {

                    postsHTML+=`
                    
                    <div class="col-3">
                        <div class="card">
                    
                        <div class="card-body">
                            <h5 class="card-title">${post.id}</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's
                                content.</p>
                            <a href="#" class="btn btn-primary">Go somewhere</a>
                        </div>
                        </div>
                        </div>
                    
                    `;
                    
                });
                $('#posts').html(postsHTML)

            },
            eror: function(err){
                console.log(err);
            }



        });
    };
    loadPosts();
})