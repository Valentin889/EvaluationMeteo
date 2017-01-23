<?php
    require_once 'ApiSimpleGetRestClient.php';
?>



<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Bootstrap 3, from LayoutIt!</title>

    <meta name="description" content="Source code generated using layoutit.com">
    <meta name="author" content="LayoutIt!">

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">

  </head>
  <body>

     
      
      
    <div class="container-fluid">
	<div class="row">
		<div class="col-md-12">
                    <h3>
                            affichage météo
                    </h3>
                    <form>
                        <select class="form-control" name ="ville" size="1">
                            <?php
                                $client = new ApiSimpleGetRestClient('http://www.prevision-meteo.ch/services/json');
                                $response =  $client->get('list-cities');
                                $data = json_decode(($response),true);

                                for($i=0; $i<count($data);$i++)
                                {
                                    echo '<option>'.$data[$i]["name"].'</option>';
                                }
                            ?>
                        </select>
                        <button type="submit" class="btn btn-primary">valider</button>
			<table class="table">
                            <thead>
                                    <tr>
                                            <th>
                                                    jour
                                            </th>
                                            <th>
                                                    photo
                                            </th>
                                            <th>
                                                température minimum
                                            </th>
                                            <th>
                                                température maximum
                                            </th>
                                    </tr>
                            </thead>
                            <tbody>
                                 <?php
                                    $client = new ApiSimpleGetRestClient('http://www.prevision-meteo.ch/services/json');
                                    $response =  $client->get('Neuchatel');
                                    if(!empty($_GET['ville']))
                                    {
                                        $response = $client->get($_GET['ville']);
                                    }
                                    $data = json_decode(($response),true);
                                    $nbJours = 5;
                                    for($i =0; $i < $nbJours; $i++)
                                    {
                                        echo '<tr>';
                                        echo '<td>'.$data["fcst_day_$i"]['day_short'].'</td>';
                                        echo '<td> <img src = '.$data["fcst_day_$i"]['icon'].' alt ="previson"></td>';
                                        echo '<td>'.$data["fcst_day_$i"]['tmin'].'</td>';
                                        echo '<td>'.$data["fcst_day_$i"]['tmax'].'</td>';
                                        echo '</tr>';
                                    }
                                ?>
                            </tbody>
			</table>
                    </form>
		</div> 
	</div>
</div>

    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/scripts.js"></script>
  </body>
</html>
                                   