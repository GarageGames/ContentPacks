singleton TSShapeConstructor(Soldier_Kral_LookDAE)
{
   baseShape = "./Soldier_Kral_Look.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "910", "920", true, true);
}
