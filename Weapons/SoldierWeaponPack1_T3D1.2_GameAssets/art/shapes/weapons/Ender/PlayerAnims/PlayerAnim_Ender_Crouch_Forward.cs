singleton TSShapeConstructor(PlayerAnim_Ender_Crouch_ForwardDAE)
{
   baseShape = "./PlayerAnim_Ender_Crouch_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "380", "409");
}
