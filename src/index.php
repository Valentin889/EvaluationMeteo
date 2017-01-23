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
                        <label> localité </label>
                        <select class="form-control" name ="ville" size="1">
                            <option>Neuchâtel</option>
                            <option>La-chaux-de-fonds</option>
                            <option>Berne</option>
                            <option>Lausanne</option>
                        </select>
                        <label> nombre de jours à afficher </label>
                        <select class="form-control" name="jours" size ="1">
                            <?php
                                for($i=1; $i<6;$i++)
                                {
                                     echo '<option>'.$i.'</option>'; 
                                }
                            ?>
                        </select>
                        <button type="submit" class="btn btn-primary" name ="validation"> valider</button>
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
                                    $nbJours = 5;
                                    if(isset($_GET['validation']))
                                    {
                                        $response = $client->get($_GET['ville']);
                                        $nbJours=$_GET['jours'];
                                    }
                                    $data = json_decode(($response),true);
                                    
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
                    <form>
                        <label> nom de la nouvelle ville </label>
                        <input type="text" name="Nouvelle_Ville">
                         <button type="submit" class="btn btn-primary" name ="EnvoieVille"> valider</button>
                    </form>
		</div> 
	</div>
</div>

    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/scripts.js"></script>
  </body>
</html>
                                   