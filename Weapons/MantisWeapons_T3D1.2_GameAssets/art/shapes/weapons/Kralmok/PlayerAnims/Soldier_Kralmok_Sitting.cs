singleton TSShapeConstructor(Soldier_Kralmok_SittingDAE)
{
   baseShape = "./Soldier_Kralmok_Sitting.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_SittingDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sitting", "1230", "1235", true, true);
}
