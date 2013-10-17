singleton TSShapeConstructor(Soldier_Kraad_Swim_ForwardDAE)
{
   baseShape = "./Soldier_Kraad_Swim_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Swim_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Forward", "1490", "1549", true, true);
}
